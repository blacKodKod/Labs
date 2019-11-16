using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassLibrary
{
    public class ZNO_Points
    {
        protected int firstPoints;
        protected int secondPoints;
        protected int thirdPoints;
        protected int fourthPoints;

        public string FirstSubject { set; get; }
        public string SecondSubject { set; get; }
        public string ThirdSubject { set; get; }
        public string FourthSubject { set; get; }

        public int FirstPoints
        {
            set
            {
                if (value >= 0 && value <= 200)
                    firstPoints = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення балів за перший предмет!!!");
                    ResetColor();
                }
            }
            get
            {
                return firstPoints;
            }
        }
        public int SecondPoints
        {
            set
            {
                if (value >= 0 && value <= 200)
                    secondPoints = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення балів за другий предмет!!!");
                    ResetColor();
                }
            }
            get
            {
                return secondPoints;
            }
        }
        public int ThirdPoints
        {
            set
            {
                if (value >= 0 && value <= 200)
                    thirdPoints = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення балів за третій предмет!!!");
                    ResetColor();
                }
            }
            get
            {
                return thirdPoints;
            }
        }
        public int FourthPoints
        {
            set
            {
                if (value >= 0 && value <= 200)
                    fourthPoints = value;
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Некоректне значення балів за четвертий предмет!!!");
                    ResetColor();
                }
            }
            get
            {
                return fourthPoints;
            }
        }

        public ZNO_Points(string firstSbj, string secondSbj, string thirdSbj, int firstPoints, int secondPoints, int thirdPoints) : this(firstSbj, secondSbj, thirdSbj, " ", firstPoints, secondPoints, thirdPoints, 0)
        {

        }
        public ZNO_Points(string firstSbj, string secondSbj, string thirdSbj, string fourthSbj, int firstPoints, int secondPoints, int thirdPoints, int fourthPoints)
        {
            FirstSubject = firstSbj;
            SecondSubject = secondSbj;
            ThirdSubject = thirdSbj;
            FourthSubject = fourthSbj;
            FirstPoints = firstPoints;
            SecondPoints = secondPoints;
            ThirdPoints = thirdPoints;
            FourthPoints = fourthPoints;
        }

        public ZNO_Points(ZNO_Points obj)
        {
            FirstSubject = obj.FirstSubject;
            SecondSubject = obj.SecondSubject;
            ThirdSubject = obj.ThirdSubject;
            FourthSubject = obj.FourthSubject;
            FirstPoints = obj.FirstPoints;
            SecondPoints = obj.SecondPoints;
            ThirdPoints = obj.ThirdPoints;
            FourthPoints = obj.FourthPoints;
        }
        
        public void ShowInfo()
        {
            if (FirstSubject != " ")
                WriteLine($"{FirstSubject,80}:{FirstPoints,4}");
            if (SecondSubject != " ")
                WriteLine($"{SecondSubject,80}:{SecondPoints,4}");
            if (ThirdSubject != " ")
                WriteLine($"{ThirdSubject,80}:{ThirdPoints,4}");
            if (FourthSubject != " ")
                WriteLine($"{FourthSubject,80}:{FourthPoints,4}");
        }
    }
}
