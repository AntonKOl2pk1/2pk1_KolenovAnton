using System.Text;

namespace pz15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string emptyString = "";
            
            StreamReader NewFile = new StreamReader("test.txt");
            while (NewFile.EndOfStream != true)
            {
                emptyString += NewFile.ReadToEnd(); //присваиваем весь текст из файла
            }
            string[] array = emptyString.Split('\n');

            for (int i = 0; i < array.Length; i++)
            { 

               //int index = array.IndexOf(i);
                if (i % 2 == 0 )
                {
                    array[i] = "";
                    
                }
                Console.WriteLine(array[i]);

            }
            
            NewFile.Close();

        }
    }
}