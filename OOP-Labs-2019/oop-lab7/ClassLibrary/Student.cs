using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected int course; //курс
        protected int group; //група
        protected int faculty; //факультет
        protected int universityName; //вищий навчальний заклад

        public string Group { set; get; }
        public string Faculty { set; get; }
        public string UniversityName { set; get; }

        public int Course
        {
            set
            {
                if (value > 0)
                    course = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення курса!!!");
                    ResetColor();
                }
            }
            get
            {
                return course;
            }
        }

        public Student() : this("Марійка", "Харипончук", new DateTime(2001, 6, 12), 1, "ПІ-60", "ФІКТ", "ЖДТУ")
        {

        }

        public Student(string name, string surname, DateTime dateOfBirth, int course, string group, string faculty, string universityName) : base(name, surname, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(Student obj) : base(obj)
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            UniversityName = obj.UniversityName;
        }

        public void PrintStudentTableInConsole()
        {
            PrintPersonTableInConsole();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("  Курс  |  Група  |  Факультет  |      ВНЗ      |");
            ResetColor();
        }

        public override void ShowInfo()
        {
            PrintStudentTableInConsole();
            base.ShowInfo();
            WriteLine($"{Course,6}{Group,11}{Faculty,13}{UniversityName,15}");
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine("Студент");
            ResetColor();
        }
    }
}
