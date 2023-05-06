using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class BookCard: IClonable
    {
        public int ID;
        public string author;
        public string title;
        public int year;
        public string condition;

        public enum BookCondition
        {
            Утилизация,
            Отличное,
            Новая
        }

        public static int ToBeDisposedCount { get; private set; }
        public static int GoodCount { get; private set; }
        public static int NewCount { get; private set; }

        public BookCard(int id, string author, string title, int year, BookCondition condition)
        {
            ID = id;
            Author = author;
            Title = title;
            Year = year;
            Condition = condition;
            UpdateCounters();
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Автор не может быть пустым");
                author = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Заголовок не может быть пустым");
                title = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1990)
                    Console.WriteLine("Год не может быть ранее 1990-го");
                year = value;
            }
        }

        public BookCondition Condition
        {
            get { return (BookCondition)Enum.Parse(typeof(BookCondition), condition); }
            set
            {
                condition = value.ToString();
                UpdateCounters();
            }
        }

        private void UpdateCounters()
        {
            switch (Condition)
            {
                case BookCondition.Утилизация:
                    ToBeDisposedCount++;
                    break;
                case BookCondition.Отличное:
                    GoodCount++;
                    break;
                case BookCondition.Новая:
                    NewCount++;
                    break;
            }
        }

        public void GetBookInfo()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Condition: {0}", Condition);
        }

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
