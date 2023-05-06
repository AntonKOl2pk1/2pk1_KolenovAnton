using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
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
            ScientificBookCard newbook1 = new ScientificBookCard(1, "Linus Pauling", "General Chemistry", 1988, BookCard.BookCondition.Отличное, ScientificBookCard.BookDirection.Химия, new DateTime(2019, 1, 1));
            ScientificBookCard newbook2 = new ScientificBookCard(2, "Stephen Hawking", "A Brief History of Time", 1988, BookCard.BookCondition.Новая, ScientificBookCard.BookDirection.Физика, new DateTime(2021, 5, 1));

            newbook1.GetBookInfo();
            newbook2.GetBookInfo();
            Console.ReadKey();
        }
    }
}
