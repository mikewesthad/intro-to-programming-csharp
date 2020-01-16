using System;
using System.Collections.Generic;
using System.Text;

namespace PaintCalculator
{
    class Circle
    {
        static string AsciiCircle = @"
        * * *
     *         *
    *           * 
    *           *
     *         *
        * * *

          └─ r ─┘
";

        double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Area of a circle formula:
        // A = π × r^2
        // https://www.mathsisfun.com/area.html
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        static public void DrawDiagram()
        {
            Console.WriteLine(AsciiCircle);
        }
    }
}
