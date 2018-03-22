using System.Windows;

namespace FigureLibrary
{
    public interface ICanvas
    {
        void DrawLine(Point point1, Point point2);
        void DrawRound(Point point1, double radius);
        void DrawRect(Point point1, Point point2);
    }
}
