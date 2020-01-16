using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ArraysDemo
{
    class Item
    {
        string Name;
        string Description;
        int Quantity;
        ConsoleColor Color;

        public Item(string name, string description, ConsoleColor color, int quantity = 1)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Color = color;
        }

        public void DisplayItem()
        {
            ForegroundColor = Color;
            WriteLine("Item:         " + Name);
            WriteLine("Description:  " + Description);
            WriteLine("Quantity:     " + Quantity);
        }
    }
}
