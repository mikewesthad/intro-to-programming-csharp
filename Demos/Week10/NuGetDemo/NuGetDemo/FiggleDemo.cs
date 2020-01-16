/* 
 * Figgle Demo
 * https://github.com/drewnoakes/figgle
 * 
 * Steps:
 * 0. Read the docs!
 * 1. Open NuGet package manager (Tools => NuGet Package Manger => Manage NuGet Packages for Solution...)
 * 2. Click browse and search for "Figgle."
 * 3. In the panel on the right side, click the checkbox for your solution and click install.
 * 4. Make some funky ASCII text to spice up your console life.
 * 
 * Figgle uses fonts from Figlet: http://www.figlet.org/examples.html. You can browse for a font 
 * on that site, or you can explore using intellisense.
 */

using System;
using static System.Console;

using Figgle;

namespace NuGetDemo
{
    static class FiggleDemo
    {
        public static void Run()
        {
            WriteLine("=== Figgle ===");

            string asciiHello = FiggleFonts.Standard.Render("Howdy!");
            WriteLine(asciiHello);

            string asciiSpooky = FiggleFonts.Ghost.Render("Enter if you dare!");
            WriteLine(asciiSpooky);
        }
    }
}
