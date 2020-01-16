using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Since we're rending out some big ASCII banner test, set the Console window to be as
            // big as possible so that it all fits on screen.
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;

            FiggleDemo.Run();
            PastelDemo.Run();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
