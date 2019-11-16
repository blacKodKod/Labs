using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    public class Ellipse : Circle
    {
        public Ellipse() : base()
        {
        }

        public Ellipse(int maxY, int maxX) : base(maxY, maxX)
        {
        }

        public Ellipse(int red, int green, int blue, int penWidth, int startX, int startY, int height, int width)
            : base(red, green, blue, penWidth, startX, startY, height, width)
        {
        }

        public override void Draw(Graphics canvas)
        {
            Pen pen = new Pen(System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue), PenWidth);
            canvas.DrawEllipse(pen, start.X, start.Y, Width, Height);
        }
    }
}
