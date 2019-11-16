using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    public class Circle : Dot
    {
        protected int height;
        protected int width;

        public int Height { get; set; }
        public int Width { get; set; }

        public Circle() : base()
        {
            var rand = new Random();
            Height = rand.Next(300);
            Width = rand.Next(300);
        }

        public Circle(int maxY, int maxX) : base(maxY, maxX)
        {
            var rand = new Random();
            Height = rand.Next(maxY);
            Width = rand.Next(maxX);
        }

        public Circle(int red, int green, int blue, int penWidth, int startX, int startY, int height, int width)
            : base(red, green, blue, penWidth, startX, startY)
        {
            Height = height;
            Width = width;
        }

        public Circle(Circle obj)
        {
            Height = obj.Height;
            Width = obj.Width;
        }

        public override void Draw(Graphics canvas)
        {
            Pen pen = new Pen(System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue), PenWidth);
            canvas.DrawEllipse(pen, start.X, start.Y, Width, Height);
        }
    }
}
