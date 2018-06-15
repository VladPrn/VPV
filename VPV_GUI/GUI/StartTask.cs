using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace VPV_GUI
{
    /// <summary> Делегат для пересылки прогресса выполнения работы из другого потока </summary>
    /// <param name="value">Процент выполненной работы от 0 до 100 </param>
    public delegate void UpdateProgress(int value);

    /// <summary> Форма для тестирования задачи </summary>
    public partial class StartTask : Form
    {
        // Количество тестов на каждую задачу
        private const int TEST_COUNT = 100;

        // Данные задачи, которую предстоит тестировать
        private TestTask task;

        // Отдельный поток, в котором будет происходить выполнение тестирования
        // Необходим для неблокирования интерфейса во время интенсивной работы
        private Thread thread;

        // Результат тестирования задачи
        // Сюда складываются результаты одиночных тестов, чтобы
        // в конце работы подсчитать средние значения и доверительные интервалы
        private TestResult res = new TestResult(100);

        // Спецальный флаг. Необходим для предотвращения каскадного изменения
        // взаимосвязанных элементов статистики
        bool singleChange;

        public StartTask(TestTask task)
        {
            this.task = task;
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы
        /// Сразу создает новый поток, в котором производит тестирования задачи
        /// </summary>
        private void StartTask_Load(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                ExportData();
                CompileVCC();
                StartVCC();
                for (int i = 0; i < 100; i++)
                {
                    res.add(StartVCC());
                    Invoke(new UpdateProgress(UpdateProgress), new object[] { i + 1 });
                }
            });
            thread.Start();
        }

        /// <summary>
        /// Событие закрытия формы
        /// Если тестрование все еще в процессе, останавливает его
        /// </summary>
        private void StartTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }

        /// <summary> Изменение поля доверительной вероятности времени работы </summary>
        private void editTimePercent_TextChanged(object sender, EventArgs e)
        {
            if (singleChange)
            {
                SetTimeValue();
            }
        }

        /// <summary> Изменение поля границы времени работы </summary>
        private void editTimeValue_TextChanged(object sender, EventArgs e)
        {
            if (singleChange)
            {
                SetTimePercent();
            }
        }

        /// <summary> Изменение поля доверительной вероятности используемой памяти </summary>
        private void editMemoryPercent_TextChanged(object sender, EventArgs e)
        {
            if (singleChange)
            {
                SetMemoryValue();
            }
        }

        /// <summary> Изменение поля границы времени используемой памяти </summary>
        private void editMemoryValue_TextChanged(object sender, EventArgs e)
        {
            if (singleChange)
            {
                SetMemoryPercent();
            }
        }

        /// <summary> Распаковывает файл *.test в отдельные файлы </summary>
        private void ExportData()
        {
            TestTask.exportFiles(task, "vs\\input.txt", "vs\\main.cpp");
        }

        /// <summary> Производит компиляцию программы на С++ </summary>
        private void CompileVCC()
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "vs\\vscompile.bat";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            myProcess.WaitForExit();
        }

        /// <summary> Запускает и тестирует программу на С++ </summary>
        /// <returns> Возвращает результат тестирования задачи (1 из 100) </returns>
        private SingleTestResult StartVCC()
        {
            // Инициализация процесса из *.exe файла
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "vs\\main.exe";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.UseShellExecute = false;

            // Запуск высокоточных счетчиков для определения затрат по времени и памяти
            Stopwatch s = Stopwatch.StartNew();
            myProcess.Start();
            PerformanceCounter theMemCounter = new PerformanceCounter("Process", "Working Set - Private", myProcess.ProcessName);

            // Переопределение потоков для работы программы
            StreamReader srin = new StreamReader(new FileStream("vs\\input.txt", FileMode.Open, FileAccess.Read));
            StreamWriter swin = myProcess.StandardInput;
            swin.Write(srin.ReadToEnd());
            srin.Close();
            swin.Close();

            // Ожидания завершения работы тестируемой программы.
            // Также подсчитывается используемая память (ее максимум)
            long maxValue = 0;
            while (!myProcess.HasExited)
            {
                try
                {
                    maxValue = Math.Max(maxValue, (long) theMemCounter.NextValue() / 1024);
                }
                catch
                {

                }
            }
            s.Stop();

            // Закрытие ввода/вывода
            StreamReader srout = myProcess.StandardOutput;
            StreamWriter swout = new StreamWriter(new FileStream("vs\\output.txt", FileMode.Create, FileAccess.Write));
            swout.Write(srout.ReadToEnd());
            swout.Close();


            return new SingleTestResult(s.ElapsedMilliseconds, maxValue);
        }

        /// <summary>
        /// Принимает информацию о прогрессе тестирования
        /// Если прогресс равен 100%, выводит результаты тестирования
        /// </summary>
        private void UpdateProgress(int value)
        {
            progressBar.Value = value;
            if (value == 100)
            {
                labelStatus.Text = "Готово!";
                res.calc();
                labelAvTime.Text += res.AverageTime + " Мс";
                labelDTime.Text += res.DTime + " Мс";
                labelAvMemory.Text += res.AverageMemory + " Кб";
                labelDMemory.Text += res.DMemory + " Кб";

                editTimePercent.Enabled = true;
                editTimeValue.Enabled = true;
                editMemoryPercent.Enabled = true;
                editMemoryValue.Enabled = true;

                SetTimeValue();
                SetMemoryValue();
            }
        }

        /// <summary> Установка границы времени работы по доверительной вероятности </summary>
        private void SetTimeValue()
        {
            try
            {
                double p = Double.Parse(editTimePercent.Text.Replace('.', ',')) / 100;
                singleChange = false;
                editTimeValue.Text = Math.Round(Statistics.getUpperValue(res.AverageTime, res.DTime, p)).ToString();
            } catch (Exception e) {

            }
            singleChange = true;
        }

        /// <summary> Установка доверительной вероятности по границе времени работы </summary>
        private void SetTimePercent()
        {
            try
            {
                double v = Double.Parse(editTimeValue.Text.Replace('.', ','));
                singleChange = false;
                editTimePercent.Text = (Statistics.getPercent(res.AverageTime, res.DTime, v) * 100).ToString("0.0");
            }
            catch (Exception e)
            {

            }
            singleChange = true;
        }

        /// <summary> Установка границы используемой памяти по доверительной вероятности </summary>
        private void SetMemoryValue()
        {
            try
            {
                double p = Double.Parse(editMemoryPercent.Text.Replace('.', ',')) / 100;
                singleChange = false;
                editMemoryValue.Text = Math.Round(Statistics.getUpperValue(res.AverageMemory, res.DMemory, p)).ToString();
            }
            catch (Exception e)
            {

            }
            singleChange = true;
        }

        /// <summary> Установка доверительной вероятности по границе используемой памяти </summary>
        private void SetMemoryPercent()
        {
            try
            {
                double v = Double.Parse(editMemoryValue.Text.Replace('.', ','));
                singleChange = false;
                editMemoryPercent.Text = (Statistics.getPercent(res.AverageMemory, res.DMemory, v) * 100).ToString("0.0");
            }
            catch (Exception e)
            {

            }
            singleChange = true;
        }
    }
}
