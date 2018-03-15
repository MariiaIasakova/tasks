using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FigureLibrary
{
    public interface ICanvas
    {
        void DrawLine(Point point1, Point point2);
        void DrawRound(Point point1, double radius);
        void DrawRect(Point point1, Point point2);
    }
}
