using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PaintCalculator
{
    class PaintCalculator
    {
        public static void Run()
        {
            BackgroundColor = ConsoleColor.Yellow;
            ForegroundColor = ConsoleColor.Black;
            Clear();

            WriteLine("======= Geometry Design's Paint Calculator =======\n");
            WriteLine("We've got paint for all your shape needs.");
            WriteLine("What kind of shape do you need us to paint? We currently support: circle, rectangle or triangle.");
            Write("Enter a shape: ");
            string choice = ReadLine().ToLower();
            double area = 0;
            WriteLine();

            if (choice == "circle")
            {
                WriteLine("Great - we'll need some circle measurements first.");
                Circle.DrawDiagram();
                Write("What's the radius of the circle (in feet): ");
                string radiusAnswer = ReadLine();
                double radius = Convert.ToDouble(radiusAnswer);
                // We can also do the above two lines in a single line:
                //  double radius = Convert.ToDouble(ReadLine());
                Circle myCircle = new Circle(radius);
                area = myCircle.GetArea();
            }
            else if (choice == "rectangle")
            {
                WriteLine("Great - we'll need some rectangle measurements first.");
                Rectangle.DrawDiagram();
                Write("What's the width (in feet): ");
                double width = Convert.ToDouble(ReadLine());
                Write("What's the height (in feet): ");
                double height = Convert.ToDouble(ReadLine());
                Rectangle rect = new Rectangle(width, height);
                area = rect.GetArea();
            }
            else if (choice == "triangle")
            {
                WriteLine("Great - we'll need some triangle measurements first.");
                Triangle.DrawDiagram();
                Write("What's the base width (in feet): ");
                double width = Convert.ToDouble(ReadLine());
                Write("What's the height (in feet): ");
                double height = Convert.ToDouble(ReadLine());
                Triangle tri = new Triangle(width, height);
                area = tri.GetArea();
            }
            else
            {
                WriteLine("You've choosen a shape we don't support yet!");
                WriteLine("Press any key to restart");
                ReadKey();
                Run();
                return;
            }

            double costPerSquareFoot = 3.5;
            double totalCost = area * costPerSquareFoot;
            WriteLine("The area of the shape is: " + Math.Round(area, 2));
            WriteLine("The total cost is: " + totalCost.ToString("C"));

            WriteLine("\n\n\nThanks for using the calculator. Press any key to exit.");
            ReadKey();
        }
    }
}
