 using System;
using static System.Console;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Static Demos");

            // By creating a PrintTitle method, we can re-use it multiple times in an efficient way
            // that saves us from typing redundant code!
            ConsoleUtils.PrintTitle("Welcome Section");
            string welcomeMessage = ConsoleUtils.CreateWelcomeMessage("Mike");
            WriteLine(welcomeMessage);

            // We didn't get to it in class, but you can imagine expanding this discount calculator
            // to accept input from the player so that they can calculate the price of an item they
            // care about instead of it always displaying 25% off $200.50.
            WriteLine();
            ConsoleUtils.PrintTitle("Discount Calculator");
            double salesPrice = Calculations.CalculateSalePrice(200.50, 25);
            WriteLine("The price is now $" + Math.Round(salesPrice, 2));

            ReadKey();
        }
    }
}
