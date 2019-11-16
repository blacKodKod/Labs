using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        protected ZNO_Points PointsZNO; //(кількість балів сертифікатів ЗНО
        protected float pointsCertificate; //кількість балів за документ про освіту
        protected string schoolName; //назва загальноосвітнього навчального закладу

        public string SchoolName { set; get; }

        public float PointsCertificate
        {
            set
            {
                if (value > 0 && value < 13)
                    pointsCertificate = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення оцінки атестата!!!");
                    ResetColor();
                }
            }
            get
            {
                return pointsCertificate;
            }
        }

        public Entrant() : this("Марійка", "Харипончук", new DateTime(2001, 6, 12), "Українська мова та літ-ра", "Математика", "Історія", " ", 189, 182, 182, 0, (float)10.5, "Олевська гімназія")
        {

        }

        public Entrant(string name, string surname, DateTime dateOfBirth, string firstSbj, string secondSbj, string thirdSbj, string fourthSbj, int firstPoints, int secondPoints, int thirdPoints, int fourthPoints, float pointsCertificate, string schoolName) : base(name, surname, dateOfBirth)
        {
            PointsZNO = new ZNO_Points(firstSbj, secondSbj, thirdSbj, fourthSbj, firstPoints, secondPoints, thirdPoints, fourthPoints);
            PointsCertificate = pointsCertificate;
            SchoolName = schoolName;
        }
        
        public Entrant(Entrant obj) : base(obj)
        {
            PointsZNO = new ZNO_Points(obj.PointsZNO);
            PointsCertificate = obj.PointsCertificate;
            SchoolName = obj.SchoolName;
        }

        public void PrintEntrantTableInConsole()
        {
            PrintPersonTableInConsole();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("              Бали ЗНО              |  Атестат  |         ВНЗ         |");
            ResetColor();
        }

        public override void ShowInfo()
        {
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine("\nЛюдина");
            ResetColor();

            PrintEntrantTableInConsole();
            base.ShowInfo();
            WriteLine($"{PointsCertificate,47}{SchoolName,22}");
            PointsZNO.ShowInfo();
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine("Абітурієнт");
            ResetColor();
        }
    }
}
