using System;
using System.Collections.Generic;
using System.Text;

namespace PaintCalculator
{
    class Rectangle
    {
        static string AsciiRectangle = @"
+---------+    ┐
|         |    │
|         |    h 
|         |    │
+---------+    ┘

└─── w ───┘
";

        double Width;
        double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Area of a rectangle formula:
        // A = width * height
        // https://www.mathsisfun.com/area.html
        public double GetArea()
        {
            return Width * Height;
        }

        static public void DrawDiagram()
        {
            Console.WriteLine(AsciiRectangle);
        }
    }
}
