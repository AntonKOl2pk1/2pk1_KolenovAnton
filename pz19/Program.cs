using System.Text.RegularExpressions;

namespace pz19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string text = reader.ReadToEnd();
            file.Close();
            string Pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+7]";
            Regex regex = new Regex(Pattern);
            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("Второй текст");
            FileStream file1 = new FileStream("text1.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(file1);

            string text1 = reader1.ReadToEnd();
            file.Close();
            string Pattern1 = @"(\d+[.]\d+[.]\d+[.]\d+\s)";
            Console.WriteLine("IP-адреса:");
            Regex regex1 = new Regex(Pattern1);
            foreach (Match match in regex1.Matches(text1))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("\nДаты:");
            string Date = @"(\d+[/]\w+[/]\d+)";
            Regex regex2 = new Regex(Date);
            foreach (Match match in regex2.Matches(text1))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}