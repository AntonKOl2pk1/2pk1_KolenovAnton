namespace pz14
{
    internal class Program
    {

        static double ArifProg(double a1, double d, int n)
        {
            if (n == 1)
            {
                return a1;
            }
            else
            {
                return ArifProg(a1, d, n - 1) + d;
            }
            //eturn ArifProg(a1, d, n - 1) + d;
        }
        static double GeomProg(double b1, double q, int n)
        {
            if (n == 1)
            {
                return b1;
            }
            else
            {
                return q * GeomProg(b1, q, n - 1);
            }
        }

        static int Numbers(int a, int b)
        {

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (b < a)
            {
                for (int i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.Write(a);
            }

            return Numbers(a, b);
        }

        static int Summ(int x)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < x; i++)
            {

                sum += 1;
               Console.Write(sum + " ");
                count += sum;
            }

            Console.Write($" = {count}");

            return (x);
        }

        static int Power(int a, int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 1)
                return Power(a, n - 1) * a;
            else
            {
                int c = Power(a, n / 2);
                return c * c;
            }
        }

        static string Palindrom(string stroka)
        {
            int len = stroka.Length;
            char[] chars = stroka.ToCharArray();
            for (int i = 0; i < len / 2; i++)
            {
                if (chars[i] == chars[len - i - 1])
                {
                   Console.WriteLine("Строка является палиндромом");
                    return chars.ToString();
                }
                else
                {
                    Console.WriteLine("Строка не является палиндромом");
                }
            }
            return stroka;

        }

        static int Inverse(int a, int b)
        {
            if (a < 10) return b * 10 + a;
            return Inverse(a / 10, b * 10 + a % 10);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Первое задание");
            double a1 = 33;
            double d = -5;
            int N;
            Console.WriteLine("N = ");
            N = Convert.ToInt32(Console.ReadLine());
            double v = ArifProg(a1, d, N);
            Console.WriteLine($"N-ый член арифметической прогрессии: {v}") ;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Второе задание");
            double b1 = 11;
            double q = -0.6;
            Console.WriteLine($"N-ый член геометрической прогрессии: {GeomProg(b1, q, N)} ");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Третье задание");
            int firstNumber = 22, secondNumber = 100;
            Console.Write("Числа между A и B: ");
            Numbers(firstNumber, secondNumber);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Четвертое задание");
            // 1 задание
            int number;
            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            Summ(number);

            // 2 задание
            int Base, power;
            Console.WriteLine("Введите основание");
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {Base} в степени {power} = {Power(Base, power)}");

            // 3 задание
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            Palindrom(str);

            // 4 задание
            int inverse;
            int invro = 0;
            Console.WriteLine("Введите число ");
            inverse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Inverse(inverse, invro));
        }
    }
}