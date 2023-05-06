using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PRICE[] SPISOK = new PRICE[8]; 

            // ввод данных в массив SPISOK
            for (int i = 0; i < SPISOK.Length; i++)
            {
                Console.WriteLine($"Введите данные для товара №{i + 1}:");
                Console.Write("Название товара: ");
                SPISOK[i].TOVAR = Console.ReadLine();
                Console.Write("Название магазина: ");
                SPISOK[i].MAG = Console.ReadLine();
                Console.Write("Стоимость товара в руб.: ");
                SPISOK[i].STOIM = decimal.Parse(Console.ReadLine());
            }
            Array.Sort(SPISOK, (x, y) => x.MAG.CompareTo(y.MAG));
            Console.Write("Введите название магазина: ");
            string magazin = Console.ReadLine();
            bool flag = false; 
            for (int i = 0; i < SPISOK.Length; i++)
            {
                if (SPISOK[i].MAG == magazin)
                {
                    flag = true;
                    Console.WriteLine($"{SPISOK[i].TOVAR} - {SPISOK[i].STOIM} руб.");
                }
            }
            if (!flag)
            {
                Console.WriteLine("Такого магазина нет в списке.");
            }

            Console.ReadKey();
        }
    }
}
