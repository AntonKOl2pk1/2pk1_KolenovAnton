using System.Diagnostics;

namespace pz16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан файл f1 с произвольным содержимым. В текущей папке создать подкаталог /new в нем 
            создать файл f2 в который перенести содержимое из файла f1(файл не удалять)*/

            string path = @"C:\Users\MSI\source\repos\pz3\pz16\bin\Debug\net6.0";
            string subpath = @"new";
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                dir.CreateSubdirectory(subpath);
            }

            //File.Create(@"new\newfile.txt");

            FileStream file = new FileStream(@"text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            FileStream file1 = new FileStream(@"new\newfile.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file1);
            if (File.Exists(@"new\newfile.txt"))
            {
                Console.WriteLine("файл создан успешно");
            }
            else
            {
                Console.WriteLine("файл не создан");
            }
            
            writer.Write(reader.ReadToEnd());
            writer.Close();
            reader.Close();
            file.Close();
            file1.Close();

        }
    }
}