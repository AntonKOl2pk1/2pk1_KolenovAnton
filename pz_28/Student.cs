using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Student
    {
        public string Name { get; private set; }
        public double AverageMark { get; private set; }

        public event EventHandler<double> MarkAdded; // Событие добавления оценки

        private int marksCount = 0;
        private double sum = 0;

        public Student(string name)
        {
            Name = name;
        }

        public void AddMark(int mark)
        {
            marksCount++;
            sum += mark;
            AverageMark = sum / marksCount;
            MarkAdded?.Invoke(this, AverageMark); // Вызываем событие добавления оценки
        }
    }
}
