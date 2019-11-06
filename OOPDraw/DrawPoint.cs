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
        public DrawPoint(Color color, Point point, float width) : base(color, point, width)
        {
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, MainPoint.X, MainPoint.Y, 3, 3);
        }
    }
}
