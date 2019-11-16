using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ClassLibrary;

namespace ConsoleExs1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;

            Title = "Лабораторна робота №7";
            SetWindowSize(130, 25);

            Person person = new Person();
            Student student = new Student("Олександр", "Сівченко", new DateTime(2001, 1, 5), 1, "ПІ-60", "ФІКТ", "ЖДТУ");
            LibraryUser libraryUser = new LibraryUser("Дмитро", "Воронков", new DateTime(2000, 9, 21), 4728, new DateTime(2019, 8, 10), 10);

            Person[] people = {
                new Person(),
                new Entrant(),
                new Student(student),
                new Teacher(),
                new LibraryUser(libraryUser),
                null
            };

            person.PrintPersonTableInConsole();
            Write("\n");

            foreach (var i in people)
            {
                if (i != null)
                {
                    i.ShowInfo();
                }
            }
        }
    }
}
