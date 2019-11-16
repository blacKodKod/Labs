using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exs1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, N = 0, n;
            do
            {
                Console.Write("Введите a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = int.Parse(Console.ReadLine());
            } while (b < a);
            Console.Write("Введите c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            n = int.Parse(Console.ReadLine());

            //step
            double h = (double)(b - a) / (double)n;

            //Method of left rectangles
            double x = a, sRect = 0;
            for (int i = 0; i < n; i++, x += h)
            {
                sRect += (-Math.Pow(x, 2) + c) * h;
            }

            //Method of trapeze
            x = a;
            double sTrap = 0;
            for (int i = 0; i < n; i++, x += h)
            {
                sTrap += (-Math.Pow(x, 2) + c) + (-Math.Pow(x + h, 2) + c);
            }
            sTrap *= h / 2;

            //Simpson's method
            double sum1 = 0, sum2 = 0;
            for (int i = 1; i < n / 2; i++)
            {
                sum1 += (-Math.Pow(a + (i * 2 - 1) * h, 2) + c);
                if (i < n / 2 - 1)
                    sum2 += (-Math.Pow((a + i * 2 * h), 2) + c);
            }
            sum1 *= 4;
            sum2 *= 2;
            double sSimps = h / 3 * (-Math.Pow(a, 2) - Math.Pow(b, 2) + c * 2 + sum1 + sum2);

            //Monte Carlo's method
            double D = Math.Abs(a - b) * c, y;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                y = rand.NextDouble() * c;
                x = rand.NextDouble() * (b - a) + a;
                if (y <= (-Math.Pow(x, 2) + c))
                    N++;
            }
            double sMC = (double)D * (double)N / n;


            Console.WriteLine($"\nМетод прямоугольников: S = {Math.Abs(sRect)}\n");
            Console.WriteLine($"Метод трапеции: S = {Math.Abs(sTrap)}\n");
            Console.WriteLine($"Метод Симпсона: S = {Math.Abs(sSimps)}\n");
            Console.WriteLine($"Метод Монте-Карло: S = {Math.Abs(sMC)}\n");
            Console.ReadKey();
        }
    }
}
