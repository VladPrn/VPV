using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPV_GUI
{
    /// <summary>
    /// Класс, обеспечивающий сохранение множества результатов работы программы
    /// Также содержит методы для подсчета средних значений
    /// </summary>
    class TestResult
    {
        private long[] time;
        private long[] memory;

        private int size;
        private int i = 0;

        public long AverageTime {get; set;}
        public long DTime { get; set; }
        public long AverageMemory { get; set; }
        public long DMemory { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="size">Планируемый объем тестов для задачи</param>
        public TestResult(int size)
        {
            this.size = size;
            this.i = 0;
            this.time = new long[size];
            this.memory = new long[size];
        }

        /// <summary>
        /// Вычисление средних значений 
        /// </summary>
        public void calc() {
            double average;

            average = getAverage(time);
            AverageTime = (long) average;
            DTime = (long) getDelta(time, average);

            average = getAverage(memory);
            AverageMemory = (long)average;
            DMemory = (long)getDelta(memory, average);
        }

        /// <summary> Добавить в набор одиночный тест </summary>
        public void add(SingleTestResult res)
        {
            time[i] = res.getTime();
            memory[i] = res.getMemory();
            i++;
        }

        /// <summary> Вычисление усредненного значения </summary>
        private double getAverage(long[] arr)
        {
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            return res / arr.Length;
        }

        /// <summary> Вычисление среднеквадратичного отклонения от значения average </summary>
        private double getDelta(long[] arr, double average)
        {
            double delta = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                delta += (average - arr[i]) * (average - arr[i]);
            }
            return Math.Sqrt(delta / arr.Length);
        }
    }
}
