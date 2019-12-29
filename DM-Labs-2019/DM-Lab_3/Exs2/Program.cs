using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Exs2
{
    class Program
    {
        static int Fact(int n)
        {
            if (n == 1 || n == 0) return 1;
            return n * Fact(n - 1);
        }

        static int[] Distinct(int[] a)
        {
            HashSet<int> list = new HashSet<int>(a);
            int[] b = new int[list.Count];
            list.CopyTo(b);
            return b;
        }

        static int DigitCount(int[] a, int b)
        {
            int count = 0;
            foreach (var i in a)
                if (i == b) count++;

            return count;
        }

        static int Number(int n)
        {
            bool check;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    if ((check = int.TryParse(ReadLine(), out a[i])) != true)
                        WriteLine("Помилка, введіть правильне значення");
                }
                while (!check) ;
            }
            int temp = Fact(n);
            foreach (var i in Distinct(a))
            {
                WriteLine("Число: {0} - повторюється {1} раз(ів)", i, DigitCount(a, i));
                temp = temp / Fact(DigitCount(a, i));
            }
            return temp;
        }

        static int Word(string s)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                chars.Add(s[i]);
            }
            int count = 0, res = 1, k = s.Length;            
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j == 0)
                        count++;
                    if (j != 0)
                    {
                        if (chars[j] == chars[i] && i != j)
                        {
                            chars.RemoveAt(j);
                            count++;
                            k--;
                        }
                    }
                }
                res *= Fact(count);
                count = 0;
            }
            return Fact(s.Length) / res;
        }
        
        static void PrintMenu()
        {
            Write("\n- - - - - - Меню - - - - - -\n" +
                "1. Звичайна перестановка\n" +
                "2. Перестановка з повтореннями\n" +
                "3. Розміщення без повторень\n" +
                "4. Розміщення з повтореннями\n" +
                "5. Сполучення без повторень\n" +
                "6. Сполучення з повтореннями\n" +
                "0. Вихід\n-> ");            
        }

        static void Main(string[] args)
        {
            Title = "Лабораторна робота №3. Харипончук Марії, гр. ПІ-60";
            SetWindowSize(50, 30);
            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;

            int menu, n, m;
            string str;
            bool check;

            do
            {
                Clear();
                PrintMenu();
                do
                {
                    if ((check = int.TryParse(ReadLine(), out menu)) != true)
                        WriteLine("!!!Помилка. Введіть коректне значення!");
                }
                while (!check);

                switch (menu)
                {
                    case 1:
                        {
                            Clear();
                            Write("\nЗвичайна перестановка.\nВведіть кількість об'єктів(n): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out n)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("\nКількість можливих способів: " + Fact(n) + "\n\n");
                            ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Clear();
                            Write("\nПерестановка з повтореннями.");
                            int num;
                            Write("\nВиберіть, що будете вводити: \n" +
                                "1. Слово \n" +
                                "2. Число \n");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out num)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);

                            switch (num)
                            {
                                case 1:
                                    Write("Введіть слово для обробки: ");
                                    str = ReadLine();
                                    Write("\nКількість можливих способів: " + Word(str) + "\n\n");
                                    ReadKey();
                                    break;
                                case 2:
                                    Write("\nВведіть кількість об'єктів(n): ");
                                    do
                                    {
                                        if ((check = int.TryParse(ReadLine(), out n)) != true)
                                            WriteLine("!!!Помилка. Введіть коректне значення!");
                                    }
                                    while (!check);
                                    int[] a = new int[n];
                                    Write("Введіть числа для обробки:\n");
                                    Write("\nКількість можливих способів: " + Number(n) + "\n\n");
                                    ReadKey();
                                    break;
                                default:
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                                    break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Clear();
                            Write("\nРозміщення без повторень.\nВведіть загальну кількість об'єктів(n): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out n)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);

                            Write("Введіть кількість об'єктів для розміщення(m): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out m)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("\nКількість можливих способів: " + Fact(n) / Fact(n - m) + "\n\n");
                            ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Clear();
                            Write("\nРозміщення з повтореннями.\nВведіть загальну кількість об'єктів(n): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out n)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("Введіть кількість об'єктів для розміщення(m): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out m)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("\nКількість можливих способів: " + Math.Pow(n, m * 1.0) + "\n\n");
                            ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Clear();
                            Write("\nСполучення без повторень.\nВведіть загальну кількість об'єктів(n): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out n)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("Введіть кількість об'єктів для розміщення(m): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out m)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("\nКількість можливих способів: " + Fact(n) / (Fact(n - m) * Fact(m)) + "\n\n");
                            ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Clear();
                            Write("\nСполучення з повтореннями.\nВведіть загальну кількість об'єктів(n): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out n)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("Введіть кількість об'єктів для розміщення(m): ");
                            do
                            {
                                if ((check = int.TryParse(ReadLine(), out m)) != true)
                                    WriteLine("!!!Помилка. Введіть коректне значення!");
                            }
                            while (!check);
                            Write("\nКількість можливих способів: " + Fact(n + m - 1) / (Fact(m) * Fact(n - 1)) + "\n\n");
                            ReadKey();
                            break;
                        }
                    case 0:
                        WriteLine("Ви вийшли з програми!");
                        break;
                    default:
                        WriteLine("!!!Помилка. Введіть коректне значення!");
                        break;
                }
            } while (menu != 0);
        }
    }
}