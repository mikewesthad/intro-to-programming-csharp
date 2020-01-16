using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace StaticDemo
{
    // A collection of static methods for common things we do in the Console.
    class ConsoleUtils
    {
        static public string CreateWelcomeMessage(string name)
        {
            string message = "Welcome, " + name + ".";
            return message;
        }

        static public void PrintTitle(string title)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("=================================");
            WriteLine(title);
            WriteLine("=================================");
        }
    }
}
