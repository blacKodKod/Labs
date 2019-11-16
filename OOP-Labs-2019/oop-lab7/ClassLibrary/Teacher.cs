using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string position; //посада
        protected string chair; //кафедра
        protected string universityName; //вищий навчальний заклад

        public string Position { set; get; }
        public string Chair { set; get; }
        public string UniversityName { set; get; }

        public Teacher() : this("Віталій", "Левківський", new DateTime(1990, 5, 7), "Вчитель", "ФІКТ", "ЖДТУ")
        {

        }

        public Teacher(string name, string surname, DateTime dateOfBirth, string position, string chair, string universityName) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityName;
        }

        public Teacher(Teacher obj) : base(obj)
        {
            Position = obj.Position;
            Chair = obj.Chair;
            UniversityName = obj.UniversityName;
        }

        public void PrintTeacherTableInConsole()
        {
            PrintPersonTableInConsole();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("   Посада   |   Кафедра   |      ВНЗ      |");
            ResetColor();
        }

        override public void ShowInfo()
        {
            PrintTeacherTableInConsole();
            base.ShowInfo();
            WriteLine($"{Position,11}{Chair,11}{UniversityName,16}");
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine("Викладач");
            ResetColor();
        }
    }
}
