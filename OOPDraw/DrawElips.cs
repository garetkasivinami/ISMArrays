using System.Drawing;

namespace OOPDraw
{
    class DrawElips : DrawCircle
    {
        public DrawElips(Color color, Point mainPoint, Point scale) : base(color, mainPoint)
        {
            this.scale.X = scale.X;
            this.scale.Y = scale.Y;
        }
    }
}
