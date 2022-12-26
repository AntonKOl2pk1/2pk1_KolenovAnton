namespace pz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 вариант
            Console.Write("Введите число от 1 до 12: ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            switch (x)
            {
                case 1:
                    Console.WriteLine("1 января - Новый год\n7 января - Рождество");
                    break;
                case 2:
                    Console.WriteLine("23 февраля - День защитника отечества");
                    break;
                case 3:
                    Console.WriteLine("8 марта - Женский день");
                    break;
                case 4:
                    Console.WriteLine("12 апреля - День космонавтики");
                    break;
                case 5:
                    Console.WriteLine("9 мая - День Победы");
                    break;
                case 6:
                    Console.WriteLine("1 июня - День детей");
                    break;
                case 7:
                    Console.WriteLine("В июле нет праздников");
                    break;
                case 8:
                    Console.WriteLine("В августе нет праздников");
                    break;
                case 9:
                    Console.WriteLine("1 сентября - День знаний");
                    break;
                case 10:
                    Console.WriteLine("6 октября - День рождение В.В.Путина");
                    break;
                case 11:
                    Console.WriteLine("В ноябре нет праздников");
                    break;
                case 12:
                    Console.WriteLine("31 декабря - Новый Год");
                    break;
                default:
                    Console.WriteLine("Вы ввели число не в диапазоне от 1 от 12");
                    break;
            }

        }
    }
}