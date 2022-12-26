using System;

namespace pz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В произвольном тексте осуществить сортировку предложений по количеству
            символов в порядке возрастания*/

            string text = 
                "\nLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                "\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                "\nExcepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            string[] array = text.Split('\n');
            int maxlen = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array);
                Console.WriteLine(array[i]);
            }
        }
    }
}