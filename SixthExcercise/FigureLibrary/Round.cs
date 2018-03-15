using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public  class Round : Figure
    {
        protected Point Point;
        protected double OutRadius;

        public Round(Point point, double radius)
        {
            Point = point;
            OutRadius = radius;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(Point, OutRadius);
        }
    }
}
