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
        public Point scale;
        public DrawCircle(Color color, Point mainPoint, int radius) : base (color, mainPoint)
        {
            scale.X = radius;
            scale.Y = radius;
        }
        public DrawCircle(Color color, Point mainPoint) : base(color, mainPoint)
        {
        }
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen,mainPoint.X, mainPoint.Y, scale.X, scale.Y);
        }
    }
}
