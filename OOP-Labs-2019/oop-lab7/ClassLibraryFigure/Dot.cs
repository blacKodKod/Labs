using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    public class Dot : Shape
    {
        protected Point start;

        public Dot()
        {
            Random rand = new Random();
            Color = new ColorRGB();
            PenWidth = rand.Next(10);
            start = new Point();
        }

        public Dot(int maxY, int maxX)
        {
            Random rand = new Random();
            Color = new ColorRGB();
            PenWidth = rand.Next(10);
            start = new Point(maxY, maxX);
        }

        public Dot(int red, int green, int blue, int penWidth, int startX, int startY)
        {
            Color = new ColorRGB(red, green, blue);
            PenWidth = penWidth;
            start = new Point(startX, startY);
        }

        public Dot(Dot obj)
        {
            Color = obj.Color;
            PenWidth = obj.PenWidth;
            start = obj.start;
        }

        public override void Draw(Graphics canvas)
        {
            Pen pen = new Pen(System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue), PenWidth);
            canvas.DrawRectangle(pen, start.X, start.Y, 1, 1);
        }
    }
}


