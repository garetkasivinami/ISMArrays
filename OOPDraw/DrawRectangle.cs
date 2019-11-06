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
            graphics.DrawRectangle(Pen, MainPoint.X - SecondPoint.X / 2, MainPoint.Y - SecondPoint.Y, SecondPoint.X, SecondPoint.Y);
        }
    }
}
