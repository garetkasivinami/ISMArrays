using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public static Random random;
        private Graphics graphics;
        private Pen pen;
        public ShapePoint[] shapePoints;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = DrawBox.CreateGraphics();
            pen = new Pen(Color.Red , 2);
            //new Thread(StartNarkomania).Start();
        }

        private void CreateDraw_Click(object sender, EventArgs e)
        {
            shapePoints = new ShapePoint[200];
            for (int i = 0; i < 200; i++)
            {
                pen.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                switch (random.Next(0, 4))
                {
                    case 0:
                        shapePoints[i] = new DrawRectangle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(20, 100), random.Next(20, 100)));
                        break;
                    case 1:
                        shapePoints[i] = new DrawLine(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)));
                        break;
                    case 2:
                        shapePoints[i] = new DrawCircle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), random.Next(10, 75));
                        break;
                    case 3:
                        shapePoints[i] = new DrawElips(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(15, 75), random.Next(15, 75)));
                        break;
                }
                shapePoints[i].Draw(graphics, pen);
            }
            //Thread.Sleep(100);
            GC.Collect();
        }
        public void StartNarkomania()
        {
            while (true)
            {
                graphics.Clear(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
                shapePoints = new ShapePoint[200];
                for (int i = 0; i < 200; i++)
                {
                    pen.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    switch (random.Next(0, 4))
                    {
                        case 0:
                            shapePoints[i] = new DrawRectangle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(20, 100), random.Next(20, 100)));
                            break;
                        case 1:
                            shapePoints[i] = new DrawLine(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)));
                            break;
                        case 2:
                            shapePoints[i] = new DrawCircle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), random.Next(10, 75));
                            break;
                        case 3:
                            shapePoints[i] = new DrawElips(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(15, 75), random.Next(15, 75)));
                            break;
                    }
                    shapePoints[i].Draw(graphics, pen);
                }
                //Thread.Sleep(100);
                GC.Collect();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
        }
    }
}
