using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCard book1 = new BookCard(1, "Агата Кристи", "Убийство в «Восточном экспрессе»", 1934, BookCard.BookCondition.Утилизация);
            BookCard book2 = new BookCard(2, "Оруэлл Джордж", "1984", 1949, BookCard.BookCondition.Отличное);
            BookCard book3 = new BookCard(3, "Харпер Ли", "Убить пересмешника", 1960, BookCard.BookCondition.Новая);
            book1.GetBookInfo();
            book2.GetBookInfo();
            book3.GetBookInfo();
            Console.ReadKey();
        }
    }
}
