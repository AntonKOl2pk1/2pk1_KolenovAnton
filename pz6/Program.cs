namespace pz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (n > 1)
            {
                n /= 2;
                k++;
            }
            Console.WriteLine($"Показатель степени: {k}");
            Console.ReadKey();
        }
    }
}