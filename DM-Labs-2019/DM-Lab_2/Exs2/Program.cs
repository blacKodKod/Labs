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
            Title = "Лабораторна робота №2. Харипончук Марії, гр. ПІ-60";
            SetWindowSize(70, 30);
            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;

            WriteLine("Вас вітає програма для знаходження матриці бінарного відношення!");
            //Відношення згідно варіанту №18: ρ={(a,b)|a є A & b є B & (2a-b)!⋮3}
                        
            int a = 0, b = 0;

            WriteLine("\nВведіть потужність множини А:");
            Write("А = ");
            a = Convert.ToInt32(ReadLine());
            int[] A = new int[a];

            for (int i = 0; i < a; i++)
            {
                A[i] = Convert.ToInt32(ReadLine());
            }

            WriteLine("\nВведіть потужність множини B:");
            Write("B = ");
            b = Convert.ToInt32(ReadLine());
            int[] B = new int[b];

            for (int i = 0; i < b; i++)
            {
                B[i] = Convert.ToInt32(ReadLine());
            }
            
            int[,] res = new int[a, b];           

            WriteLine("\tМатриця відношення:");

            for (int i = 0; i < res.GetLength(1); i++)
            {
                Write($"\t{B[i]}");
            }
            WriteLine();
            WriteLine();

            for (int i = 0; i < res.GetLength(0); i++)
            {
                Write($"{A[i]}");
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if ((2 * A[i] - B[j]) % 3 == 0)
                        Write("\t1");
                    else
                        Write("\t0");
                }
                WriteLine();
            }
            WriteLine();            
        }
    }
}
