using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    public class Rectangle : Line
    {
        public Rectangle() : base()
        {
        }

        public Rectangle(int maxY, int maxX) : base(maxY, maxX)
        {
        }

        public Rectangle(int red, int green, int blue, int penWidth, int startX, int startY, int endX, int endY)
            : base(red, green, blue, penWidth, startX, startY, endX, endY)
        {
        }

        public override void Draw(Graphics canvas)
        {
            Pen pen = new Pen(System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue), PenWidth);
            canvas.DrawRectangle(pen, start.X, start.Y, Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
        }
    }
}
