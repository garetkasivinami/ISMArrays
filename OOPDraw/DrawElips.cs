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
            graphics.DrawEllipse(Pen, MainPoint.X - ScaleX / 2, MainPoint.Y - ScaleY / 2,ScaleX, ScaleY);
        }
    }
}
