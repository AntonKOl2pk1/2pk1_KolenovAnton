using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Teacher
    {
        private double criticalValue = 2.4; // Критическое значение успеваемости

        public void OnMarkAdded(object sender, double averageMark)
        {
            if (averageMark <= criticalValue)
            {
                Console.WriteLine($"{((Student)sender).Name}, ваша успеваемость ниже критического значения: {averageMark}");
            }
        }
    }
}
