using System;
using static System.Console;

namespace ClassLibrary
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected DateTime DateOfBirth;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Person() : this("Марійка", "Харипончук", new DateTime(2001, 6, 12))
        {

        }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(Person obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            DateOfBirth = obj.DateOfBirth;
        }

        public void PrintPersonTableInConsole()
        {
            ForegroundColor = ConsoleColor.DarkMagenta;
            Write("\n\n|     Ім'я     |   Прізвище   |  Дата народження  |");
            ResetColor();
        }

        public virtual void ShowInfo()
        {
            Write($"{Name,15}{Surname,15}{DateOfBirth.ToString("d"),20}");
        }
    }
}
