using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;

namespace Task3
{
    public class ConcoleDraw : ICanvas
    {
        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Линия ({point1.X}, {point1.Y}) ({point2.X}, {point2.Y})");
        }

        public void DrawRect(Point point1, Point point2)
        {
            Console.WriteLine($"Прямоугольник ({point1.X}, {point1.Y}), ({point2.X}, {point2.Y})");
        }

        public void DrawRound(Point point1, double radius)
        {
            Console.WriteLine($"Круг в ({point1.X}, {point1.Y}) с радиусом {radius}");
        }
    }
}
