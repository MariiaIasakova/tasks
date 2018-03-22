using System.Windows;

namespace FigureLibrary
{
    public class Line : Figure
    {
        private Point point1, point2;

        public Line(Point outPoint1, Point outPoint2)
        {
            point1 = outPoint1;
            point2 = outPoint2;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawLine(point1, point2);
        }
    }
}
