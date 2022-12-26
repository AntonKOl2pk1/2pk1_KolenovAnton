namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Найти произведение и сумму максимального и минимального из n введенных чисел
(массива) и их индексы. Посчитать среднее арифметическое всех элементов массива
*/

            int[] array;
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            int max, min;
            int indexmin, indexmax;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

            max = array.Max();
            indexmax = Array.IndexOf(array, max);
            min = array.Min();
            indexmin = Array.IndexOf(array, min);
            Console.WriteLine($"Максимальный элемент: {max}, индекс - {indexmax}");
            Console.WriteLine($"Минимальный элемент: {min}, индекс - {indexmin}");

            int proizvedenie = min * max;
            int summa = max + min;
            Console.WriteLine($"Произведение - {proizvedenie}\nСумма - {summa}");

            int summa_array = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summa_array += array[i];
            }
            double sr_arif = summa_array / n;
            Console.WriteLine($"Среднее арифметическое - {sr_arif}");
        }
    }
}