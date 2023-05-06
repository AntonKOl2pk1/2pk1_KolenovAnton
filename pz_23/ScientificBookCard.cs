using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    public class ScientificBookCard : BookCard
    {
        public enum BookDirection
        {
            Химия,
            Медицина,
            Физика,
            Математика,
            Биология
        }
        public BookDirection Direction;
        public DateTime ReceiptDate
        {
            get { return receiptDate; }
            set
            {
                if (DateTime.Now.Year - value.Year <= 5)
                {
                    receiptDate = value;
                }
                else
                {
                    Console.WriteLine("Дата получения не может быть более 5 лет назад.");
                }
            }
        }

        private DateTime receiptDate;

        public ScientificBookCard(int id, string author, string title, int year, BookCondition condition, BookDirection direction, DateTime receiptDate) : base(id, author, title, year, condition)
        {
            Direction = direction;
            ReceiptDate = receiptDate;
        }

        public new void GetBookInfo()
        {
            base.GetBookInfo();
            Console.WriteLine($"Направление: {Direction}");
            Console.WriteLine($"Дата получения: {ReceiptDate.ToShortDateString()}");
        }
    }

}
