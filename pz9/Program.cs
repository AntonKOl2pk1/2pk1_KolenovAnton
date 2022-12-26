namespace pz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = random.Next(3, 20);
            int[][] array = new int[4][];
            int k = 0;
            Console.WriteLine("1 задание");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new int[k = random.Next(5, 50)];

                for (int j = 0; j < k; j++)
                {
                    array[i][j] = random.Next(3, 21);
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.Write("3 задание ");
            int[] arrayEnd = new int[6];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                arrayEnd[i] = array[i][array[i].Length - 1];
                Console.Write(arrayEnd[i] + " ");
            }
            Console.WriteLine();


            Console.Write("4 задание ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(arrayEnd[i] = array[i].Max());
            }
            Console.WriteLine();


            Console.WriteLine("5 задание");
            int firstValue = 0;
            int maxValue = 0;
            for (int i = 0, j = 0; i < array.GetLength(0); i++)
            {
                maxValue = array[i].Max();
                int index = Array.IndexOf(array[i], maxValue);
                firstValue = array[i][j];
                array[i][j] = array[i].Max();
                array[i][index] = firstValue;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("6 задание");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}