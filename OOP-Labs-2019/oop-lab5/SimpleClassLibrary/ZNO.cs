using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class ZNO
    {
        protected string subject; //назва предмет
        protected double points; //результат

        public string Subject;
        public double Points;

        public ZNO()
        {

        }

        public ZNO(string subject, double points)
        {
            Subject = subject;
            Points = points;
        }

        public ZNO(ZNO obj)
        {
            Subject = obj.subject;
            Points = obj.points;
        }
    }
}