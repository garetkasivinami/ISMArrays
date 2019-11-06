using System.Drawing;

namespace OOPDraw
{
    public class DrawLine : DrawPoint
    {
        public Point SecondPoint;
        public DrawLine(Color color, Point firstPoint, Point secondPoint, float width) : base(color, firstPoint, width)
        {
            SecondPoint = secondPoint;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, MainPoint, SecondPoint);
        }
    }
}
