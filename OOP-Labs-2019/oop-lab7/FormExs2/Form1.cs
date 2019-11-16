using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryFigure;


namespace FormExs2
{
    public partial class Form1 : Form
    {
        protected Bitmap BitCanvas;
        protected Graphics canvas;
        protected Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            BitCanvas = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draws();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            pictureBoxCanvas.Image = null;
        }

        private void Draws()
        {
            canvas = Graphics.FromImage(BitCanvas);
            Shape[] array = new Shape[20];
            for (int i = 0; i < array.Length; i++)
            {
                switch (rand.Next(6))
                {
                    case 1:
                        array[i] = new Dot();
                        array[i].Draw(canvas);
                        break;
                    case 2:
                        array[i] = new Line();
                        array[i].Draw(canvas);
                        break;
                    case 3:
                        array[i] = new Circle(rand.Next(255), rand.Next(255), rand.Next(255), rand.Next(25), 5, 8, rand.Next(300), rand.Next(300));
                        array[i].Draw(canvas);
                        break;
                    case 4:
                        array[i] = new Ellipse(rand.Next(255), rand.Next(255), rand.Next(255), rand.Next(15), 5, 12, rand.Next(377), rand.Next(788));
                        array[i].Draw(canvas);
                        break;
                    case 5:
                        array[i] = new ClassLibraryFigure.Rectangle(rand.Next(300), rand.Next(300));
                        array[i].Draw(canvas);
                        break;
                }
            }
            pictureBoxCanvas.Image = BitCanvas;
        }
    }
}
