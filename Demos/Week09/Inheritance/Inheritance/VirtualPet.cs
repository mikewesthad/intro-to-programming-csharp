using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    class VirtualPet
    {
        // Protected is a new "access modifier" that we can use, in addition to public
        // and private:
        //  - public - any code can access
        //  - private - only the containing class can access
        //  - protected - the containing class and any dervied classes can access

        // By making these protected, it means we can access them from within Dragon.
        protected string Name;
        protected string Type;
        protected double Weight;
        protected ConsoleColor Color;
        protected Present currentPresent;

        public VirtualPet()
        {
            // When you create a derived class from VirtualPet, unless you specify a constructor
            // (like we eventually did in Dragon), the derived class will try to call the base
            // constructor with no parameters. We added this empty constructor in VirtualPet
            // initially to address that, then we refactored Dragon to call the 4-parameter
            // VirtualPet constructor.
            Name = "Unknown";
            Type = "Generic Pet";
            Weight = 0;
            Color = ConsoleColor.White;
        }

        public VirtualPet(string name, ConsoleColor color, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Color = color;
        }

        public void Greet()
        {
            ForegroundColor = Color;
            WriteLine($"Hi, my name is {Name}.");
            WriteLine($"I'm a {Type}.");

            // == is an equality check, it will return true if two things ARE equal.
            // != is an inequality check, it will return true if two things are NOT equal.
            if (currentPresent != null)
            {
                WriteLine($"I have a {currentPresent.Name}");
            }

            ResetColor();
        }

        public void TakePresent(Present present)
        {
            currentPresent = present;
        }

        // By marking this as virtual, we allow subclasses to override it.
        public virtual void DrawAvatar()
        {
            ForegroundColor = Color;
            WriteLine(Avatars.Smiley);
            ResetColor();
        }
    }
}
