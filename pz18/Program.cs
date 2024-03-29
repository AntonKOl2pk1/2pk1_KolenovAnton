﻿namespace pz18
{
    internal class Program
    {

        enum Marks
        {
            very_bad = 1,
            bad = 2,
            satisfactory = 3,
            good = 4,
            excellent = 5
        }

        enum Seasons
        {
            winter = 1,
            spring = 2,
            summer = 3,
            autumn = 4
        };

        static void MarksEnum(ref Marks mark, int ozenka)
        {
            switch (ozenka)
            {
                case 1:
                    mark = Marks.very_bad;
                    Console.Write("очень плохо");
                    break;
                case 2:
                    mark = Marks.bad;
                    Console.Write("неудовлетворитлеьно");
                    break;
                case 3:
                    mark = Marks.satisfactory;
                    Console.Write("удовлетворительно");
                    break;
                case 4:
                    mark = Marks.good;
                    Console.Write("хорошо");
                    break;
                case 5:
                    mark = Marks.excellent;
                    Console.Write("отлично");
                    break;
                default:
                    Console.Write("ввели неправильную отметку");
                    break;
            }
        }

        static void WinterHolidays()
        {
            Console.WriteLine("День Героев Отечества — 9 декабря\nДень Конституции Российской Федерации  — 12 декабря\nРождество Христово у западных христиан — 25 декабря\nСтарый Новый год — 14 января\nКрещение Господне — 19 января\nДень Республики Крым — 20 января\nДень студента | Татьянин день — 25 января\nДень полного освобождения Ленинграда от фашистской блокады — 27 января\nДень святого Валентина  День всех влюбленных — 14 февраля");
        }

        static void SpringHolidays()
        {
            Console.WriteLine("Масленица — 28.02.-06.03. (в 2022 году)\nДень воссоединения Крыма с Россией (выходной день в Республике Крым) — 18 марта\nДень моряка-подводника — 19 марта\nВсемирный день поэзии — 21 марта\nДень Балтийского моря — 22 марта\nЧас Земли (экологическая акция) — 26 марта (в 2022 году)\nДень смеха (День дурака) — 1 апреля\nБлаговещение — 7 апреля\nВсемирный день космонавтики и авиации (Памятная дата России) — 12 апреля\nВербное воскресенье — 17 апреля (в 2022 году)\nДень победы русских воинов князя Александра Невского над немецкими рыцарями на Чудском озере (Ледовое побоище) (День воинской славы России) — 18 апреля\nДень принятия Крыма, Тамани и Кубани в состав Российской империи (Памятная дата России) — 19 апреля\nНациональный день донора в России — 20 апреля\nПасха — 24 апреля (в 2022 году)\nДень участников ликвидации последствий радиационных аварий и катастроф и памяти жертв этих аварий и катастроф (Памятная дата России) — 26 апреля\nДень российского парламентаризма (Памятная дата России) — 27 апреля\nДень радио — 7 мая\nДень славянской письменности и культуры — 24 мая\nДень пограничника — 28 мая");
        }

        static void SummerHolidays()
        {
            Console.WriteLine("\nМеждународный день защиты детей — 01 июня\nПушкинский день | День русского языка — 06 июня\nТроица | День Святой Троицы — 12 июня (в 2022 году)\nДень медицинского работника — 19 июня (в 2022 году)\nДень памяти и скорби | День начала Великой Отечественной войны (Памятная дата России) — 22 июня\nДень молодежи России — 27 июня\nДень партизан и подпольщиков (Памятная дата России) — 29 июня\nДень ветеранов боевых действий — 1 июля\nДень ГИБДД МВД России — 3 июля\nИван Купала — 7 июля\nВсероссийский день семьи, любви и верности — 8 июля\nКурбан Байрам — 9 июля (в 2022 году)\nДень победы русской армии над шведами в Полтавском сражении (День воинской славы России) — 10 июля\nДень Крещения Руси (Памятная дата России) — 28 июля\nДень Военно-Морского Флота России — 31 июля (в 2022 году)\nДень памяти российских воинов, погибших в Первой мировой войне (Памятная дата России) — 1 августа\nДень железнодорожника — 7 августа (в 2022 году)\nДень Воздушно-десантных войск России — 2 августа\nДень строителя — 14 августа (в 2022 году)\nДень победы русского флота под командованием Петра Первого над шведами у мыса Гангут (День воинской славы России) — 9 августа\nДень Военно-воздушных сил России — 12 августа\nМеждународный день молодежи — 12 августа\nПреображение Господне — 19 августа\nДень Воздушного Флота России — 21 августа (в 2022 году)\nДень офицера России — 21 августа\nДень Государственного флага Российской Федерации — 22 августа\nДень разгрома советскими войсками немецко-фашистских войск в Курской битве (День воинской славы России) — 23 августа\nУспение Пресвятой Богородицы — 28 августа\nДень шахтера — 29 августа");
        }

        static void AutumnHolidays()
        {
            Console.WriteLine("\nДень знаний —  1 сентября\nДень российской гвардии — 2 сентября\nДень окончания Второй мировой войны — 3 сентября\nДень нефтяника — 4 сентября (в 2022 году)\nДень Бородинского сражения (День воинской славы России) — 6 сентября\nДень танкиста в России — 11 сентября (в 2022 году)\nДень победы русской эскадры над турецкой эскадрой у мыса Тендра (День воинской славы России) — 11 сентября\nУсекновения главы Пророка, Предтечи и Крестителя Господня Иоанна — 11 сентября\nДень победы русских полков в Куликовской битве (День воинской славы России) — 21 сентября\nРождество Пресвятой Богородицы — 21 сентября\nДень машиностроителя — 25 сентября (в 2022 году)\nВоздвижение Честного Креста Господня — 27 сентября\nДень ОМОН в России — 3 октября\nДень Космических войск России — 4 октября\nВсемирный день учителя — 5 октября\nДень разгрома советскими войсками немецко-фашистских войск в битве за Кавказ (День воинской славы России) — 9 октября\nПокров Пресвятой Богородицы — 14 октября\nДень военного связиста в России — 20 октября\nДень автомобилиста — 30 октября (в 2022 году)\nХэллоуин — 31 октября\nДень проведения военного парада на Красной площади в 1941 году — (День воинской славы России) 7 ноября\nДень сотрудника органов внутренних дел Российской Федерации — 10 ноября\nДень ракетных войск и артиллерии в России — 19 ноября\nДень бухгалтера в России — 21 ноября\nДень морской пехоты России — 27 ноября\nДень матери в России — 27 ноября (в 2022 году)");

        }

        static void HolidaysEnum(ref Seasons season, int number)
        {
            switch (number)
            {
                case 1:
                    season = Seasons.spring;
                    SpringHolidays();
                    break;
                case 2:
                    season = Seasons.summer;
                    SummerHolidays();
                    break;
                case 3:
                    season = Seasons.autumn;
                    AutumnHolidays();
                    break;
                case 4:
                    season = Seasons.winter;
                    WinterHolidays();
                    break;
                default:
                    Console.Write("неправильно");
                    break;
            }
        }

        static void SeasonCheck(string season)
        {
            if (season == "весна")
            {
                Seasons season1 = Seasons.spring;
                int number = 1;
                HolidaysEnum(ref season1, number);
            }
            else if (season == "лето")
            {
                Seasons season1 = Seasons.summer;
                int number = 2;
                HolidaysEnum(ref season1, number);
            }
            else if (season == "осень")
            {
                Seasons season1 = Seasons.autumn;
                int number = 3;
                HolidaysEnum(ref season1, number);
            }
            else if (season == "зима")
            {
                Seasons season1 = Seasons.winter;
                int number = 4;
                HolidaysEnum(ref season1, number);
            }
            else
            {
                Console.WriteLine("Введено неверное время года");
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введите отметку: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваша оценка - ");
            Marks characteristic = Marks.very_bad;
            MarksEnum(ref characteristic, mark);

            Console.WriteLine("----------------------");

            Console.Write("Введите время года: ");
            string season = Console.ReadLine();
            Seasons season1 = Seasons.winter;
            SeasonCheck(season);
            
        }
    }
}