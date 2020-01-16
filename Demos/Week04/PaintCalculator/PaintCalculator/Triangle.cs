using System;
using System.Collections.Generic;
using System.Text;

namespace PaintCalculator
{
    class Triangle
    {
        static string AsciiTriangle = @"
      / \        ┐
     /   \       │
    /     \      h
   /       \     │
  /_________\    ┘

  └─── w ───┘
";

        double Width;
        double Height;

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Area of a triangle formula:
        // A = 1/2 * base * height
        // https://www.mathsisfun.com/area.html
        public double GetArea()
        {
            return 0.5 * Width * Height;
        }

        static public void DrawDiagram()
        {
            Console.WriteLine(AsciiTriangle);
        }
    }
}
