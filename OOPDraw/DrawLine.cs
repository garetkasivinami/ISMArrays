using System.Drawing;

namespace OOPDraw
{
    public class DrawLine : DrawPoint
    {
        public Point SecondPoint;
        public DrawLine(Color color, Point firstPoint, Point secondPoint) : base(color, firstPoint)
        {
            SecondPoint = secondPoint;
        }
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, mainPoint, SecondPoint);
        }
    }
}
