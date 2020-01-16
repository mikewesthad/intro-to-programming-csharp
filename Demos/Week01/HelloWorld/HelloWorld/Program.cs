/*
 * HelloWorld by Michael Hadley
 * Intro to Programming, 09/05/19
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mike's first app";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            // Ask the console to print a greeting.
            Console.WriteLine("Hello!");

            // Wait until a key is pressed.
            Console.ReadKey();

            /*
             * This
             * Is
             * A 
             * Multi-line
             * Comment.
             */

            // Play an annoying 10000hz sound for 2000ms (after the user has pressed a key!)
            Console.Beep(10000, 2000);
        }
    }
}
