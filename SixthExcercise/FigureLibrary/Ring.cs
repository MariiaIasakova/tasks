using System;
using System.Windows;

namespace FigureLibrary
{
    public class Ring : Round
    {
        protected double InnerRadius;

        public Ring(Point point, double outRadius, double innerRadius) : base(point, outRadius)
        {
            InnerRadius = innerRadius;
            if (OutRadius == innerRadius || outRadius < innerRadius)
            {
                throw new ArgumentException("inner radius must be less than out");
            }
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(Point, InnerRadius);
            canvas.DrawRound(Point, OutRadius);
        }
    }
}
