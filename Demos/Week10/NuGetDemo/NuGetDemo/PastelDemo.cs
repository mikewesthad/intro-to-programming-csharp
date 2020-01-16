/* 
 * Pastel Demo
 * https://github.com/silkfire/Pastel
 * 
 * Steps:
 * 0. Read the docs!
 * 1. Open NuGet package manager (Tools => NuGet Package Manger => Manage NuGet Packages for Solution...)
 * 2. Click browse and search for "Pastel."
 * 3. In the panel on the right side, click the checkbox for your solution and click install.
 * 4. And now you'll never be stuck with the Microsoft default console colors again!
 * 
 * Optional, if you want to use the Color class:
 * 1. In the Solution Explorer, right click on "References" and select "Add Reference"
 * 2. Search for "System.Drawing" and check the box.
 * 3. Add "using Color = System.Drawing.Color;" to your file.
 * 
 * Online color picker: http://hslpicker.com/
 */

using System;
using static System.Console;
using Pastel;
using Color = System.Drawing.Color;

namespace NuGetDemo
{
    static class PastelDemo
    {
        public static void Run()
        {
            WriteLine("=== Pastel ===");

            // Pastel adds methods a Pastel and PastelBg method to the string class. These let you
            // wrap up a string with special characters so that it renders in the choosen color.

            // Using hexadecimal colors (which look like #rrggbb):
            // Pop open the debugger and compare message and colorfulMessage - see the extra characters?
            string message = "I'm so colorful";
            string colorfulMessage = message.Pastel("#f000b8");
            WriteLine(colorfulMessage);

            // Or in one line:
            WriteLine("I'm colorful too".Pastel("#ff0000"));

            // Using System.Drawing.Color (which specifies R, G and B values between 0 - 255):
            string quote = "You feelin lucky";
            Color quoteColor = Color.FromArgb(0, 255, 255);
            string colorfulQuote = quote.Pastel(quoteColor);
            WriteLine(colorfulQuote);

            // System.Drawing.Color allows us to use variables to construct the color:
            for (int r = 0; r <= 255; r += 10)
            {
                WriteLine(
                    "I'm a gradient..."
                        .Pastel(Color.FromArgb(r, 0, 0))
                        .PastelBg(Color.FromArgb(255, 255, 255))
                );
            }
        }
    }
}
