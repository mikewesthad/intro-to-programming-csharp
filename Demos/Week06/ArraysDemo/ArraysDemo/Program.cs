using System;
using static System.Console;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunPrimitiveTypesDemo();
            RunClassTypesDemo();

            WriteLine("\nPress any key to exit...");
            // Passing in true means don't display the key that is pressed in the window.
            ReadKey(true);
        }

        static void RunClassTypesDemo()
        {
            // This is a demo of how to create an array using a custom class. This is great any
            // time you need to pack multiple pieces of data into each element in your array.
            WriteLine("The player's inventory:");
            Item[] inventory = new Item[3];
            inventory[0] = new Item("Potion", "A melting potion - DO NOT DRINK", ConsoleColor.Red);
            inventory[1] = new Item("Ultron", "A toy model of ultron - don't make it angry", ConsoleColor.Blue, 5);
            inventory[2] = new Item("Car", "A PT Cruiser toy car", ConsoleColor.Yellow);
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i].DisplayItem();
            }

        }

        static void RunPrimitiveTypesDemo()
        {
            // This demos some simple arrays composed of primitive types. For more, see the 
            // homework solution.

            int[] scores = new int[3];
            scores[0] = 10;
            scores[1] = 12;
            scores[2] = 13;
            // This will cause an error:
            //scores[3] = 11;

            string[] inventory = { "ball", "shield", "blade", "ocarina" };
            Console.WriteLine("--- Inventory ---");
            foreach(string item in inventory)
            {
                Console.WriteLine(" > " + item);
            }
        }
    }
}
