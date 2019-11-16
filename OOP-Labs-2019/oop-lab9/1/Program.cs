using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFraction;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(-2, 5);
            var b = new Fraction(3, 7);
            Console.WriteLine("a = -2/5" + "\tb = 3/7");
            Console.WriteLine("a + b = " + (a + b).ToString());
            Console.WriteLine("a - b = " + (a - b).ToString());
            Console.WriteLine("a * b = " + (a * b).ToString());
            Console.WriteLine("a / b = " + (a / b).ToString());
            Console.WriteLine("a > b - " + (a > b).ToString());
            Console.WriteLine("a >= b - " + (a >= b).ToString());
            Console.WriteLine("a < b - " + (a < b).ToString());
            Console.WriteLine("a <= b - " + (a <= b).ToString());
            Console.WriteLine("a == b - " + (a == b).ToString());
            Console.WriteLine("a != b - " + (a != b).ToString());
        }
    }
}
