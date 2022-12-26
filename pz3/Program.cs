namespace pz3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //11 вариант
            Console.Write("Введите целое число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите действительное число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double s;
            double t;
            if (y < 2)
            {
                s = y - (y * Math.Pow(x, 2)) / (x + 1);
                if (s <= 0)
                {
                    t = (y * s) + Math.Sin(x) + y;
                    double v = (2 * y * x) + (3 * y * s) - (s * t);
                    Console.WriteLine($"Y = {y}\nX = {x}\nS = {s}\nT = {t}\nV = {v}");
                }
                else if (s > 0)
                {
                    t = s - Math.Pow(Math.Cos(s/x),2);
                    double v = (2 * y * x) + (3 * y * s) - (s * t);
                    Console.WriteLine($"Y = {y}\nX = {x}\nS = {s}\nT = {t}\nV = {v}");
                }
            }
            else if (y >=2)
            {
                s = -10.6 * x * y;
                if (s <= 0)
                {
                    t = (y * s) + Math.Sin(x) + y;
                    double v = (2 * y * x) + (3 * y * s) - (s * t);
                    Console.WriteLine($"Y = {y}\nX = {x}\nS = {s}\nT = {t}\nV = {v}");
                }
                else if (s > 0)
                {
                    t = s - Math.Pow(Math.Cos(s / x), 2);
                    double v = (2 * y * x) + (3 * y * s) - (s * t);
                    Console.WriteLine($"Y = {y}\nX = {x}\nS = {s}\nT = {t}\nV = {v}");
                }
            }





        }
    }
}