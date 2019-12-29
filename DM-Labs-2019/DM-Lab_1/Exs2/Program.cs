using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Лабораторна робота №1. Харипончук Марії, гр. ПІ-60";
            SetWindowSize(70, 30);
            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;

            WriteLine("Вас вiтає програма для операцiй над множинами!");

            bool check;
            int n;
            Write("\nВведiть кiлькiсть елементiв множини A: ");
            do 
            {
                if ((check = int.TryParse(ReadLine(), out n)) != true)
                    WriteLine("Помилка, введіть правильне значення");
            }
            while (!check);
            
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Write("№" + (i + 1) + " елемент: ");
                    if ((check = int.TryParse(ReadLine(), out A[i])) != true)
                        WriteLine("Помилка, введіть правильне значення");
                }
                while (!check);
            }
            
            int num;
            Write("\nВведiть кiлькiсть елементiв множини B: ");
            do 
            {
                if ((check = int.TryParse(ReadLine(), out num)) != true)
                    WriteLine("Помилка, введіть правильне значення");
            }
            while (!check);
            
            int[] B = new int[num];
            for (int j = 0; j < num; j++)
            {
                do
                {
                    Write("№" + (j + 1) + " елемент: ");
                    if ((check = int.TryParse(ReadLine(), out B[j])) != true)
                        WriteLine("Помилка, введіть правильне значення");
                }
                while (!check);
            }
            
            Array.Sort(A);
            Array.Sort(B);

            WriteLine("\nА = {" + string.Join(", ", A) + "}");
            WriteLine("B = {" + string.Join(", ", B) + "}\n");

            WriteLine("\tОб'єднання множин:");
            WriteLine("A U B = {" + string.Join(", ", A.MyUnion(B)) + "}");
            WriteLine("\tПерерiз множин:");
            WriteLine("A ∩ B = {" + string.Join(", ", A.MyIntersection(B)) + "}");
            WriteLine("\tРiзниця множин:");
            WriteLine("A \\ B = {" + string.Join(", ", A.MyDifference(B)) + "}");
            WriteLine("\tСиметрична рiзниця множин:");
            WriteLine("A ∆ B = {" + string.Join(", ", A.MySymmetricDifference(B)) + "}");
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> left, IEnumerable<T> right)
        {
            var C = left.Concat(right).Distinct();
            return C.OrderBy(s => s);
        }

        public static IEnumerable<T> MyIntersection<T>(this IEnumerable<T> left, IEnumerable<T> right)
        {
            var C = left.Intersect(right);
            return C.OrderBy(s => s);
        }

        public static IEnumerable<T> MyDifference<T>(this IEnumerable<T> left, IEnumerable<T> right)
        {
            var C = left.Except(right);
            return C.OrderBy(s => s);
        }

        public static IEnumerable<T> MySymmetricDifference<T>(this IEnumerable<T> left, IEnumerable<T> right)
        {
            var C = left.MyDifference(right).MyUnion(right.MyDifference(left));
            return C.OrderBy(s => s);
        }
    }
}