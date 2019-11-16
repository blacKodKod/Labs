using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibraryFigure
{
    abstract public class Shape
    {
        protected class ColorRGB
        {
            protected int red, green, blue;

            public int Red
            {
                get
                {
                    return red;
                }
                set
                {
                    if (value >= 0 && value <= 255)
                        red = value;
                }
            }

            public int Green
            {
                get
                {
                    return green;
                }
                set
                {
                    if (value >= 0 && value <= 255)
                        green = value;
                }
            }

            public int Blue
            {
                get
                {
                    return blue;
                }
                set
                {
                    if (value >= 0 && value <= 255)
                        blue = value;
                }
            }

            public ColorRGB()
            {
                Random rand = new Random();

                Red = rand.Next(256);
                Green = rand.Next(256);
                Blue = rand.Next(256);
            }

            public ColorRGB(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }

            public ColorRGB(ColorRGB obj)
            {
                Red = obj.Red;
                Green = obj.Green;
                Blue = obj.Blue;
            }
        }

        protected class Point
        {
            protected int x, y;

            public int X
            {
                set
                {
                    if (value > 0)
                        x = value;
                }

                get
                {
                    return x;
                }
            }
            public int Y
            {
                set
                {
                    if (value > 0)
                        y = value;
                }

                get
                {
                    return y;
                }
            }

            public Point()
            {
                Random rand = new Random();
                X = rand.Next(200);
                Y = rand.Next(200);
            }

            public Point(int maxY, int maxX)
            {
                Random rand = new Random();
                X = rand.Next(maxX);
                Y = rand.Next(maxY);
            }

            public Point(Point obj)
            {
                X = obj.X;
                Y = obj.Y;
            }
        }
        protected ColorRGB Color;

        public int PenWidth { set; get; }

        public abstract void Draw(Graphics canvas);
    }
}
