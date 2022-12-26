namespace pz12
{
    internal class Program
    {
        /*Даны координаты вершин многоугольника(X1,Y1,X2,Y2,…,X10,Y10). Определить его
периметр (вычисление расстояния между вершинами оформить методом).
*/

        static void Main(string[] args)
        {

            Console.Write("x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3=");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3=");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine(perimetr(f(x1, y1, x2, y2), f(x2, y2, x3, y3), f(x1, y1, x3, y3)));
            Console.ReadKey();

        }
        static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static double perimetr(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}