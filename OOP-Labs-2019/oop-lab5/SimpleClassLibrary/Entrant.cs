using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleClassLibrary
{
    public class Entrant
    {
        protected string name; //прізвище та ініціали абітурієнт
        protected string idNum; //ідентифікаційний код абітурієнта
        protected int coursePoints; //бали за підготовчі курс
        protected double avgPoints; //бал атестат
        protected ZNO ZNOResults;
        public ZNO Sub1, Sub2, Sub3, Sub4;
        public double compMark;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Некоректне введення!!! Повторіть спробу");
                    ResetColor();
                }
                else
                    name = value;
            }
        }

        public string IdNum
        {
            get { return idNum; }
            set
            {
                if (value.Length == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Некоректне введення!!! Повторіть спробу");
                    ResetColor();
                }
                else
                    idNum = value;
            }
        }

        public int CoursePoints;
        public double AvgPoints;
        public double CompMark;

        public Entrant()
        {
            Name = "Anonim Anonimus";
            IdNum = "21584GK41584";
            CoursePoints = 120;
            AvgPoints = 8.3;
            ZNOResults = new ZNO();
        }

        public Entrant(string name, string idNum, int coursePoints, double avgPoints, ZNO sub1, ZNO sub2, ZNO sub3, ZNO sub4, string subject, double points, double compMark)
        {
            Name = name;
            IdNum = idNum;
            CoursePoints = coursePoints;
            AvgPoints = avgPoints;
            Sub1 = new ZNO(sub1);
            Sub2 = new ZNO(sub2);
            Sub3 = new ZNO(sub3);
            Sub4 = new ZNO(sub4);
            ZNOResults = new ZNO(subject, points);
            CompMark = compMark;
        }

        public Entrant(Entrant obj)
        {
            Name = obj.name;
            IdNum = obj.idNum;
            CoursePoints = obj.coursePoints;
            AvgPoints = obj.avgPoints;
            ZNOResults = new ZNO(obj.ZNOResults);
            CompMark = obj.compMark;
        }

        static public double GetCompMark(Entrant x)
        {
            double result = x.CoursePoints * 0.05 + x.AvgPoints * 0.1 + x.ZNOResults.Points * 0.25 + x.ZNOResults.Points * 0.4 + x.ZNOResults.Points * 0.2;
            return result;
        }

        public string GetBestSubject(Entrant x)
        {
            string best;
            if (x.Sub1.Points > x.Sub2.Points && x.Sub1.Points > x.Sub3.Points && x.Sub1.Points > x.Sub4.Points)
                best = x.Sub1.Subject;
            else
                if (x.Sub2.Points > x.Sub3.Points && x.Sub2.Points > x.Sub4.Points)
                best = x.Sub2.Subject;
            else
                if (x.Sub3.Points > x.Sub4.Points)
                best = x.Sub3.Subject;
            else
                best = x.Sub4.Subject;
            return best;

        }

        public string GetWorstSubject(Entrant x)
        {
            string worst;
            if (x.Sub1.Points < x.Sub2.Points && x.Sub1.Points < x.Sub3.Points && x.Sub1.Points < x.Sub4.Points)
                worst = x.Sub1.Subject;
            else
                if (x.Sub2.Points < x.Sub3.Points && x.Sub2.Points < x.Sub4.Points)
                worst = x.Sub2.Subject;
            else
                if (x.Sub3.Points < x.Sub4.Points)
                worst = x.Sub3.Subject;
            else
                worst = x.Sub4.Subject;
            return worst;
        }
    }
}