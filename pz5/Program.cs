namespace pz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char b = 'M';
            char sym = '#';

            //первое задание
            Console.WriteLine("Первое задание");
            for (int i = 30; i <= 120; i += 3)
            {
                Console.WriteLine(i);
            };

            //второе задание
            Console.WriteLine("\nВторое задание");
            for (int i = 0; i <= 5; i++)
            {

                Console.Write($"{b} ");
                b++;
            };

            // третье задание
            Console.WriteLine("\n\nТретье задание");
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 6; j++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine(sym);
            }

            //четвертое задание
            Console.WriteLine("\nЧетвертое задание");
            for (int i = 0; i <= 100; i += 1)
            {
                if (i % 7 == 0)
                {
                    Console.Write($"{i} ");
                }

            }

            //пятое задание
            Console.WriteLine("\nПятое задание"); //извините у меня была проблема с этим, я не могу понять как правильно это записать 
            for (int i = 4, j = 50; j - i != 12; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}