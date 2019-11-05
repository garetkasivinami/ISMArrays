using System.Drawing;

namespace OOPDraw
{
    class DrawElips : DrawCircle
    {
        public int ScaleY;
        public DrawElips(Color color, Point mainPoint, Point scale, float width) : base(color, mainPoint, width)
        {
            ScaleX = scale.X;
            ScaleY = scale.Y;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color, Width), MainPoint.X, MainPoint.Y, ScaleX, ScaleY);
        }
    }
}
