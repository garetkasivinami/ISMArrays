using System.Drawing;

namespace OOPDraw
{
    public class DrawRectangle : DrawLine
    {
        public DrawRectangle(Color color, Point firstPoint, Point Scale, float width) : base(color, firstPoint, Scale, width)
        {

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color,Width), MainPoint.X, MainPoint.Y, SecondPoint.X, SecondPoint.Y);
        }
    }
}
