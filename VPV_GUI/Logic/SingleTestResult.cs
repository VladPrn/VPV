using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPV_GUI
{
    /// <summary>
    /// Результат выполнения единичного теста
    /// (время работы программы и максимальное значение используемой памяти)
    /// </summary>
    class SingleTestResult
    {
        private long time;
        private long memory;

        public SingleTestResult(long time, long memory)
        {
            this.time = time;
            this.memory = memory;
        }

        public long getTime()
        {
            return time;
        }

        public long getMemory()
        {
            return memory;
        }
    }
}
