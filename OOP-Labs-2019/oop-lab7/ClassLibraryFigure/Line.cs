using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    public class Line : Dot
    {
        protected Point end;

        public Line() : base()
        {
            end = new Point();
        }

        public Line(int maxY, int maxX) : base(maxY, maxX)
        {
            end = new Point();
        }

        public Line(int red, int green, int blue, int penWidth, int startX, int startY, int endX, int endY)
            : base(red, green, blue, penWidth, startX, startY)
        {
            end.X = endX;
            end.Y = endY;
        }

        public Line(Line obj)
        {
            end = obj.end;
        }

        public override void Draw(Graphics canvas)
        {
            Pen pen = new Pen(System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue), PenWidth);
            canvas.DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }
    }
}
