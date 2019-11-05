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
        public float Width;
        public DrawPoint(Color color, Point point, float width) : base(color, point)
        {
            Width = width;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color,Width), MainPoint.X, MainPoint.Y, 3, 3);
        }
    }
}
