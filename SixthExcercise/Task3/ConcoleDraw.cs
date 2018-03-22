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
            Console.WriteLine($"Line ({point1.X}, {point1.Y}) ({point2.X}, {point2.Y})");
        }

        public void DrawRect(Point point1, Point point2)
        {
            Console.WriteLine($"Rectangle ({point1.X}, {point1.Y}), ({point2.X}, {point2.Y})");
        }

        public void DrawRound(Point point1, double radius)
        {
            Console.WriteLine($"Round in ({point1.X}, {point1.Y}) with radius {radius}");
        }
    }
}
