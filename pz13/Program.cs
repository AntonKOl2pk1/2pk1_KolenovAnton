namespace pz13
{
    internal class Program
    {
        /*Реализуйте метод, принимающий в качестве параметра строку, содержащую некоторую
формулу. Метод возвращает true либо false в зависимости от того, является ли строка
корректной формулой (будем считать ее корректной, если количество открывающих и
закрывающих скобок одинаково)
*/

        static void Math(string stroka)
        {
            char[] chars = stroka.ToCharArray();
            
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(')
                {
                    count1++;
                }
                if (chars[i] == ')')
                {
                    count2++;
                }
            }

            if (count1 == count2)
            {
                Console.WriteLine("Строка введена верно");
            }
            else
            {
                Console.WriteLine("Cтрока введена неверно");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите математическое выражение: ");
            string stroka = Console.ReadLine();
            Math(stroka);

        }
    }
}