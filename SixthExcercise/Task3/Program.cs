using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;

namespace Task3
{
    class Program
    {
        static Random randomGenerator = new Random();

        public static Point RandomPoint()
        {
            Point point = new Point
            {
                X = randomGenerator.Next(-10, 10),
                Y = randomGenerator.Next(-10, 10)
            };
            return point;
        }
        public static double RandomRadius()
        {
            return randomGenerator.Next(1, 20);
        }

        static void Main(string[] args)
        {
            Figure[] figureArray = new Figure[10];

            for (int i = 0; i < figureArray.Length; i++)
            {
                switch (randomGenerator.Next(4))
                {
                    case 0:
                        figureArray[i] = new Line(RandomPoint(), RandomPoint());
                        break;
                    case 1:
                        figureArray[i] = new Round(RandomPoint(), RandomRadius());
                        break;
                    case 2:
                        figureArray[i] = new Ring(RandomPoint(), RandomRadius(), RandomRadius());
                        break;
                    case 3:
                        figureArray[i] = new Rectangle(RandomPoint(), RandomPoint());
                        break;
                }
            }

            ConcoleDraw console = new ConcoleDraw();

            for (int i = 0; i < figureArray.Length; i++)
            {
                figureArray[i].Draw(console);
            }
            Console.ReadKey();
        }
    }
}
