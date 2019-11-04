using System.Drawing;

namespace OOPDraw
{
    public class DrawRectangle : DrawLine
    {
        public DrawRectangle(Color color, Point firstPoint, Point Scale) : base(color, firstPoint, Scale)
        {

        }
        public override void Draw(Graphics graphics, Pen pen)
        {
            /*
            graphics.DrawLine(pen, mainPoint.X, mainPoint.Y, SecondPoint.X, mainPoint.Y);
            graphics.DrawLine(pen, mainPoint.X, mainPoint.Y, mainPoint.X, SecondPoint.Y);
            graphics.DrawLine(pen, mainPoint.X, SecondPoint.Y, SecondPoint.X, SecondPoint.Y);
            graphics.DrawLine(pen, SecondPoint.X, mainPoint.Y, SecondPoint.X, SecondPoint.Y);
            */

            graphics.DrawRectangle(pen, mainPoint.X, mainPoint.Y, SecondPoint.X, SecondPoint.Y);
        }
    }
}
