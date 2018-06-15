using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VPV_GUI
{
    /// <summary>
    /// Класс задачи (исполняемой программы с входными данными)
    /// Предоставляет методы для загрузки/сохранения из/в файл(а).
    /// </summary>
    public class TestTask
    {
        public String Name { get; set; }
        public String Language { get; set; }
        public String Date { get; set; }

        public String Input { get; set; }
        public String Source { get; set; }
        public String Path { get; set; }

        /// <summary>
        /// Сохранение задачи в файл
        /// </summary>
        /// <param name="path"> Путь к файлу </param>
        public void save(String path)
        {
            StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            String tmp;
            StreamReader sr;

            sw.WriteLine(Name);
            sw.WriteLine(Language);
            sw.WriteLine(Date);

            sr = new StreamReader(new FileStream(Input, FileMode.Open, FileAccess.Read));
            tmp = sr.ReadToEnd();
            sr.Close();
            sw.WriteLine(tmp.Length);
            sw.Write(tmp);

            sr = new StreamReader(new FileStream(Source, FileMode.Open, FileAccess.Read));
            tmp = sr.ReadToEnd();
            sr.Close();
            sw.WriteLine(tmp.Length);
            sw.WriteLine(tmp);

            sw.Close();
        }

        /// <summary>
        /// Производит загрузку задачи из *.test файла
        /// </summary>
        /// <param name="path"> Путь к файлу </param>
        /// <returns> Загруженная задача </returns>
        public static TestTask load(String path)
        {
            TestTask task = new TestTask();
            task.Path = path;
            StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            task.Name = sr.ReadLine();
            task.Language = sr.ReadLine();
            task.Date = sr.ReadLine();
        
            sr.Close();

            return task;
        }

        /// <summary>
        /// Функция, выполняющая выделения из *.test файл отдельных файлов исходного кода и входных данных
        /// </summary>
        /// <param name="task">   Сама задача </param>
        /// <param name="input">  Путь к файлу, в который будут экспортированы входные данные </param>
        /// <param name="source"> Путь к файлу, в который будет экспортирован исходный код </param>
        public static void exportFiles(TestTask task, String input, String source)
        {
            StreamReader sr = new StreamReader(new FileStream(task.Path, FileMode.Open, FileAccess.Read));
            StreamWriter sw;
            char[] arr;
            int size;

            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();

            size = Int32.Parse(sr.ReadLine());
            arr = new char[size];
            sr.Read(arr, 0, size);
            sw = new StreamWriter(new FileStream(input, FileMode.Create, FileAccess.Write));
            sw.Write(arr);
            sw.Close();

            size = Int32.Parse(sr.ReadLine());
            arr = new char[size];
            sr.Read(arr, 0, size);
            sw = new StreamWriter(new FileStream(source, FileMode.Create, FileAccess.Write));
            sw.Write(arr);
            sw.Close();

            sr.Close();
        }
    }
}
