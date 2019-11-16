using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        protected int numOfReadersTicket; //номер читацького квитка
        protected DateTime DateOfIssue; //дата видачі
        protected int payment; // розмір щомісячного читацького внеску

        public int NumOfReadersTicket
        {
            set
            {
                if (value > 0)
                    numOfReadersTicket = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення номера читацького квитка!!!");
                    ResetColor();
                }
            }
            get
            {
                return numOfReadersTicket;
            }
        }

        public int Payment
        {
            set
            {
                if (value > 0)
                    payment = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення розміру щомісячного читацького внеску!!!");
                    ResetColor();
                }
            }
            get
            {
                return payment;
            }
        }

        public LibraryUser() : this("Марійка", "Харипончук", new DateTime(2001, 6, 12), 4728, new DateTime(2019, 8, 10), 10)
        {

        }

        public LibraryUser(string name, string surname, DateTime dateOfBirth, int numOfReadersTicket, DateTime dateOfIssue, int payment) : base(name, surname, dateOfBirth)
        {
            NumOfReadersTicket = numOfReadersTicket;
            DateOfIssue = dateOfIssue;
            Payment = payment;
        }

        public LibraryUser(LibraryUser obj) : base(obj)
        {
            NumOfReadersTicket = obj.numOfReadersTicket;
            DateOfIssue = obj.DateOfIssue;
            Payment = obj.payment;
        }

        public void PrintLibraryUserTableInConsole()
        {
            PrintPersonTableInConsole();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("  Номер читацького квитка  |  Дата видачі  |  Щомісячний читацький внесок  |");
            ResetColor();
        }

        override public void ShowInfo()
        {
            PrintLibraryUserTableInConsole();
            base.ShowInfo();
            WriteLine($"{NumOfReadersTicket,23}{DateOfIssue.ToString("d"),21}{Payment,28}грн");
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine("Користувач бібліотеки");
            ResetColor();
        }
    }
}
