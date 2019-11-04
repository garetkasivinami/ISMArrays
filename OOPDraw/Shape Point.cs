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
        public Color color; // щоб не співпадало з назвою структури
        public ShapePoint(Color color)
        {
            this.color = color;
        }
        public abstract void Draw(Graphics graphics, Pen pen);
    }
}
