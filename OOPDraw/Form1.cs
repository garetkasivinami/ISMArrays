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
        public List<ShapePoint> ShapePoints = new List<ShapePoint>();
        public Thread CleanThread;
        private bool Drawing;
        private DrawLine Line;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            CleanThread = new Thread(Cleaner);
            CleanThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = DrawBox.CreateGraphics();
            pen = new Pen(Color.Red, 2);
            graphics.Clear(Color.White);
        }

        private void CreateDraw_Click(object sender, EventArgs e)
        {
            ShapePoints.Clear();
            DrawRandomShapes(Count.Value);
            DrawBox.Refresh();
        }
        private void DrawRandomShapes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                pen.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                switch (random.Next(0, 4))
                {
                    case 0:
                        ShapePoints.Add(new DrawRectangle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(10, DrawBox.Width / 2), random.Next(10, DrawBox.Height / 2)), pen.Width));
                        break;
                    case 1:
                        ShapePoints.Add(new DrawLine(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), pen.Width));
                        break;
                    case 2:
                        ShapePoints.Add(new DrawCircle(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), random.Next(10, DrawBox.Width / 2), pen.Width));
                        break;
                    case 3:
                        ShapePoints.Add(new DrawElips(pen.Color, new Point(random.Next(0, DrawBox.Width), random.Next(0, DrawBox.Height)), new Point(random.Next(15, DrawBox.Width / 2), random.Next(15, DrawBox.Height / 2)), pen.Width));
                        break;
                }
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ShapePoints.Clear();
            DrawBox.Refresh();
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.Clear(Color.White);
            if (ShapePoints.Count > 0)
            {
                for (int i = 0; i < ShapePoints.Count; i++)
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
        #region Малювання мишкою
        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drawing = true;
                Point startMousePos = new Point(e.X, e.Y);
                Line = new DrawLine(pen.Color, startMousePos, startMousePos, pen.Width);
                ShapePoints.Add(Line);
            } else if (e.Button == MouseButtons.Right)
            {
                GetColor.ShowDialog();
                pen.Color = GetColor.Color;
            }
        }

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawing)
            {
                Line.SecondPoint = new Point(e.X, e.Y);
                DrawBox.Refresh();
            }
        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            Drawing = false;
        }
        #endregion
    }
}
