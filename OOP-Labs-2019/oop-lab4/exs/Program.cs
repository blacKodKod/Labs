using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace exs
{
    class Program
    {
        struct Name
        {
            public string FirstName;
            public string SurName;
            public string FatherName;
            public Name(string firstName, string surName, string fatherName)
            {
                FirstName = firstName;
                SurName = surName;
                FatherName = fatherName;
            }
        }
        struct ZNO
        {
            public string Subject;
            public int Points;
            public ZNO(string subject, int points)
            {
                Subject = subject;
                Points = points;
            }
        }
        struct Entrant
        {
            public Name Name;
            public ZNO Sub1, Sub2, Sub3, Sub4;
            public string IdName;
            public int CoursePoints;
            public int AvgPoints;
            public int FullPoints;
            public double CompMark;
            public Entrant(Name name, ZNO sub1, ZNO sub2, ZNO sub3, ZNO sub4, string idName, int coursePoints, int avgPoints, int fullPoints, double compMark = 0)
            {
                Name = name;
                Sub1 = sub1;
                Sub2 = sub2;
                Sub3 = sub3;
                Sub4 = sub4;
                IdName = idName;
                CoursePoints = coursePoints;
                AvgPoints = avgPoints;
                FullPoints = fullPoints;
                CompMark = compMark;
            }
            static public double GetCompMark(Entrant x)
            {
                int result = (int)(x.CoursePoints * 0.05 + x.AvgPoints * 0.1 + x.Sub1.Points * 0.25 + x.Sub2.Points * 0.4 + x.Sub3.Points * 0.2);
                return result;
            }
            public string GetBestSubject(Entrant x)
            {
                string best;
                if (x.Sub1.Points > x.Sub2.Points && x.Sub1.Points > x.Sub3.Points && x.Sub1.Points > x.Sub4.Points)
                    best = x.Sub1.Subject;
                else
                    if (x.Sub2.Points > x.Sub3.Points && x.Sub2.Points > x.Sub4.Points)
                    best = x.Sub2.Subject;
                else
                    if (x.Sub3.Points > x.Sub4.Points)
                    best = x.Sub3.Subject;
                else
                    best = x.Sub4.Subject;
                return best;
            }
            public string GetWorstSubject(Entrant x)
            {
                string worst;
                if (x.Sub1.Points < x.Sub2.Points && x.Sub1.Points < x.Sub3.Points && x.Sub1.Points < x.Sub4.Points)
                    worst = x.Sub1.Subject;
                else
                    if (x.Sub2.Points < x.Sub3.Points && x.Sub2.Points < x.Sub4.Points)
                    worst = x.Sub2.Subject;
                else
                    if (x.Sub3.Points < x.Sub4.Points)
                    worst = x.Sub3.Subject;
                else
                    worst = x.Sub4.Subject;
                return worst;
            }
        }
        static void CheckInt(out int x, int max = 200, int min = 0)
        {
            bool ok;
            do
            {
                ok = int.TryParse(ReadLine(), out x);
                if (!ok || x < min || x > max)
                    WriteLine("Некоректне введення! Повторіть спробу.");
            } while (!ok || x < min || x > max);
        }
        static Entrant[] ReadEntrantsArray()
        {
            Entrant[] array;
            Write("К-сть елементів масиву N = ");
            int n; CheckInt(out n, 200, 1);
            array = new Entrant[n];
            for (int i = 0; i < n; i++)
            {
                WriteLine($"\t [{i}]");
                Write("Ім'я абітурієнта ");
                array[i].Name.FirstName = ReadLine();
                Write("Прізвище ");
                array[i].Name.SurName = ReadLine();
                Write("По батькові ");
                array[i].Name.FatherName = ReadLine();
                Write("ІН ");
                array[i].IdName = ReadLine();
                Write("Бали за підготовчі курси ");
                CheckInt(out array[i].CoursePoints, 100, 0);
                Write("Бал атестата ");
                CheckInt(out array[i].AvgPoints, 200, 100);
                Write("Назва 1 предмету ЗНО ");
                array[i].Sub1.Subject = ReadLine();
                Write("Бал ");
                CheckInt(out array[i].Sub1.Points, 200, 100);
                Write("Назва 2 предмету ЗНО ");
                array[i].Sub2.Subject = ReadLine();
                Write("Бал ");
                CheckInt(out array[i].Sub2.Points, 200, 100);
                Write("Назва 3 предмету ЗНО ");
                array[i].Sub3.Subject = ReadLine();
                Write("Бал ");
                CheckInt(out array[i].Sub3.Points, 200, 100);
                Write("Назва 4 предмету ЗНО ");
                array[i].Sub4.Subject = ReadLine();
                if (array[i].Sub4.Subject != "")
                {
                    Write("Бал ");
                    CheckInt(out array[i].Sub4.Points, 200, 100);
                }
                array[i].CompMark = Entrant.GetCompMark(array[i]);
            }
            return array;
        }
        static void PrintTable()
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("       Ім'я   |   Прізвище   |   По-батькові   |    ІН    |   Отри-мані бали   |");
            ResetColor();
        }
        static void PrintEntrant(Entrant x)
        {
            Write($"{x.Name.FirstName,13}{x.Name.SurName,15}{x.Name.FatherName,18}{x.IdName,11}  ");
            if (x.CoursePoints > 0)
                Write($"Курси: {x.CoursePoints}\n{null,60}");
            Write($"Атестат: {x.FullPoints}\n{null,60}");
            Write($"{x.Sub1.Subject}: {x.Sub1.Points}\n{null,60}");
            Write($"{x.Sub2.Subject}: {x.Sub2.Points}\n{null,60}");
            Write($"{x.Sub3.Subject}: {x.Sub3.Points}\n{null,60}");
            if (x.Sub4.Points > 0)
                Write($"{x.Sub4.Subject}: {x.Sub4.Points}\n{null,60}");
            WriteLine($"Середній: {x.CompMark}\n");
        }
        static void PrintEntrants(Entrant[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {ForegroundColor = ConsoleColor.Magenta;
                Write($"{i}");
                ResetColor();
                
                PrintEntrant(array[i]);
            }
        }
        static void GetEntrantsInfo(Entrant[] array, out int minCompMark, out int maxCompMark)
        {
            minCompMark = 200;
            maxCompMark = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompMark > maxCompMark)
                    maxCompMark = i;
                if (array[i].CompMark < minCompMark)
                    minCompMark = i;
            }
        }
        static void SortEntrantsByPoints(Entrant[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].CompMark = Entrant.GetCompMark(array[i]);
            }
            double[] arrayTmp = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                arrayTmp[i] = array[i].CompMark;
            Array.Sort(arrayTmp, array);
        }
        static void SortEntrantsByName(Entrant[] array)
        {
            string[] arrayTmp = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
                arrayTmp[i] = array[i].Name.SurName;
            Array.Sort(arrayTmp, array);
        }
        static int PrintMenu()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Red;
            WriteLine("МЕНЮ");
            ResetColor();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Ввести масив студентів - 1");
            WriteLine("Вивести студентів - 2");
            WriteLine("Сортувати масив студентів - 3");
            WriteLine("Інфа про конкурсний бал - 4");
            WriteLine("Вийти - 0");
            ResetColor();
            int x; CheckInt(out x, 4);
            return x;
        }
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;
            Title = "Лабораторна робота №4";
            SetWindowSize(100, 25);
            int check;
            Entrant[] array;
            WriteLine("Введіть масив студентів");
            array = ReadEntrantsArray();
            do
            {
                check = PrintMenu();
                switch (check)
                {
                    case 1:
                        Clear();
                        array = ReadEntrantsArray();
                        break;
                    case 2:
                        WriteLine("Усіх - 1");
                        WriteLine("Одного - 2");
                        WriteLine("Вихід - 0");
                        CheckInt(out check, 2);
                        switch (check)
                        {
                            case 1:
                                Clear();
                                PrintTable();
                                PrintEntrants(array);
                                break;
                            case 2:
                                WriteLine("Номер");
                                int x; CheckInt(out x, array.Length - 1);
                                Clear();
                                PrintTable();
                                PrintEntrant(array[x]);
                                break;
                            case 0:
                                break;
                        }
                        break;
                    case 3:
                        WriteLine("За середнім балом - 1");
                        WriteLine("За прізви - 2");
                        WriteLine("Вихід - 0");
                        CheckInt(out check, 2);
                        switch (check)
                        {
                            case 1:
                                SortEntrantsByPoints(array);
                                break;
                            case 2:
                                SortEntrantsByName(array);
                                break;
                            case 0:
                                break;
                        }
                        Clear();
                        PrintTable();
                        PrintEntrants(array);
                        break;
                    case 4:
                        Clear();
                        int minCompMark, MaxCompMark;
                        GetEntrantsInfo(array, out minCompMark, out MaxCompMark);
                        WriteLine($"Найвищий конкурсний бал: {array[MaxCompMark].CompMark}\nНайнижчий конкурсний бал: {array[minCompMark].CompMark}");
                        break;
                    case 0:
                        break;
                }
            } while (check != 0);
        }
    }
}
