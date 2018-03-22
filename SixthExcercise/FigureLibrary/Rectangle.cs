using System;
using System.Windows;

namespace FigureLibrary
{
    public class Rectangle : Figure
    {
        private Point point1;
        private Point point2;

        public Rectangle(Point outPoint1, Point outPoint2)
        {
            point1 = outPoint1;
            point2 = outPoint2;
            if (point1.X == point2.X || point1.Y == point2.Y)
            {
                throw new Exception("it is not rectangle");
            }
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRect(point1, point2);
        }
    }
}
