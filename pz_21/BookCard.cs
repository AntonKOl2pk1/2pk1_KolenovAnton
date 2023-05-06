using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class BookCard
    {
        public int ID { get; set; } //Уникальный номер
        public string Author { get; set; } //автор
        public string Title { get; set; } //название
        public int Year { get; set; } // Год издения экземпляра
        public string Condition { get; set; } //Состояние книги

        public void GetBookInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Condition: {Condition}");
        }

    }
}
