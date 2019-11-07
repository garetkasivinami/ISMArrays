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
        public ShapePoint[] ShapePoints;
        public Thread CleanThread;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            new Thread(Cleaner).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = DrawBox.CreateGraphics();
            pen = new Pen(Color.Red, 2);
            graphics.Clear(Color.White); // не працює
        }

        private void CreateDraw_Click(object sender, EventArgs e)
        {
            ShapePoints = new ShapePoint[Count.Value];

            for (int i = 0; i < ShapePoints.Length; i++)
            {
                pen.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                switch (random.Next(0, 4))
                {
                    case 0:
                        ShapePoints[i] = new DrawRectangle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(10, 50), random.Next(10, 50)), pen.Width);
                        break;
                    case 1:
                        ShapePoints[i] = new DrawLine(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), pen.Width);
                        break;
                    case 2:
                        ShapePoints[i] = new DrawCircle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), random.Next(10, 75), pen.Width);
                        break;
                    case 3:
                        ShapePoints[i] = new DrawElips(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(15, 75), random.Next(15, 75)), pen.Width);
                        break;
                }
            }
            DrawBox.Refresh();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            ShapePoints = null;
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.Clear(Color.White);
            if (ShapePoints != null)
            {
                for (int i = 0; i < ShapePoints.Length; i++)
                {
                    ShapePoints[i].Draw(graphics);
                }
            }
        }
        private void Count_Scroll(object sender, EventArgs e)
        {
            CountLabel.Text = Count.Value.ToString();
        }
        private void Cleaner()
        {
            while (true)
            {
                Thread.Sleep(5000);
                GC.Collect();
            }
        }
    }
}
