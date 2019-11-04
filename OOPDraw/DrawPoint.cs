using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    public class DrawPoint : ShapePoint
    {
        public Point mainPoint;
        public DrawPoint(Color color, Point point) : base(color)
        {
            mainPoint = point;
        }
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, mainPoint.X, mainPoint.Y, 3, 3);
        }
    }
}
