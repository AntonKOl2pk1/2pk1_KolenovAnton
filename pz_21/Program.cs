using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCard book = new BookCard();
            book.ID = 1;
            book.Author = "Джордж Оруэлл";
            book.Title = "1984";
            book.Year = 1949;
            book.Condition = "Отличное";
            book.GetBookInfo();
            Console.ReadKey();  
        }
    }
}
