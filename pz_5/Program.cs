namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            for (byte i = 30; i <= 120; i += 3)
                Console.WriteLine(i);

            Console.WriteLine("Задние 2");

            for (char i = 'B'; i != 'B' + '5'; i++)
                Console.Write(i);


            Console.WriteLine("Задание 3");

            for (byte i = 0; i < 6; i++)
            {
                for (byte c = 0; c < 4; c++)
                {
                    Console.Write('#');

                }

                Console.WriteLine("Задание 4- не выполнено");

                Console.WriteLine("Задание 5");

                byte j = 50;
                for (byte с = 4; j - с >= 12; с++)
                {
                    Console.WriteLine($"i = {с}\tj = {j}\tразница = {j - с}");
                    --j;
                }
            }






        }


    }
}