using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class DrawCircle : DrawPoint
    {
        public int ScaleX;
        public DrawCircle(Color color, Point mainPoint, int radius, float width) : base (color, mainPoint, width)
        {
            ScaleX = radius;
        }
        public DrawCircle(Color color, Point mainPoint) : base(color, mainPoint, 0)
        {
        }
        public DrawCircle(Color color, Point mainPoint, float width) : base(color, mainPoint, width)
        {
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color,Width),MainPoint.X, MainPoint.Y, ScaleX, ScaleX);
        }
    }
}
