using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    public abstract class ShapePoint
    {
        public Pen Pen;
        public Point MainPoint;
        public ShapePoint(Color color, Point mainPoint, float width)
        {
            Pen = new Pen(color, width);
            MainPoint = mainPoint;
        }
        public abstract void Draw(Graphics graphics);
    }
}
