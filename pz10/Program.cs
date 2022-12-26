namespace pz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан символ C и строка S. Удвоить каждое вхождение символа C в строке S

            Console.Write("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();

            char[] array = stroka.ToCharArray();
            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == symbol)
                {
                    stroka = stroka.Insert(i, symbol.ToString());
                }
            }
            Console.WriteLine(stroka);

        }
    }
}