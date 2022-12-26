namespace pz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вычислить сумму элементов каждого столбца матрицы (двумерного массива).

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(100);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine($"Сумма в столбце {i} равна {sum}");
            }

        }
    }
}