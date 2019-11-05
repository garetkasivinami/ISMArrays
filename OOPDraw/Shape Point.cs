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
        public Color Color;
        public Point MainPoint;
        public ShapePoint(Color color, Point mainPoint)
        {
            this.Color = color;
            MainPoint = mainPoint;
        }
        public abstract void Draw(Graphics graphics);
    }
}
