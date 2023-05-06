using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 Вариант
            var student = new Student("Иванов");
            var teacher = new Teacher();

            student.MarkAdded += teacher.OnMarkAdded;

            Console.WriteLine($"Студент: {student.Name}");
            Console.WriteLine("Введите оценки (от 1 до 5):");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int mark))
                {
                    if (mark >= 1 && mark <= 5)
                    {
                        student.AddMark(mark);
                    }
                    else
                    {
                        Console.WriteLine("Оценка должна быть от 1 до 5.");
                    }
                }
                else
                {
                    Console.WriteLine("Введите целое число.");
                }
            }
        }
    }
}
