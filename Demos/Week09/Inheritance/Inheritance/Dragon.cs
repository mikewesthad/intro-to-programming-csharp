using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    // This is how we declare that "Dragon" inherits from "VirtualPet".
    class Dragon : VirtualPet
    {
        // Properties that only Dragon has, not VirtualPet.
        string Treasure;
        double WingSpan;

        // When you have a constructor on a derived class, it implicitly calls the base class
        // constructor. If we want to control which constructor it uses, we can use the following
        // syntax, where we call the 4-parameter version of the VirtualPet constructor.
        public Dragon(string name, ConsoleColor color, string treasure, double wingSpan)
            : base(name, color, "Dragon", wingSpan * 100)
        {
            Treasure = treasure;
            WingSpan = wingSpan;
        }

        public void Fly()
        {
            ForegroundColor = Color;
            WriteLine($"{Name}, the {Type}, is now flying.");
            ResetColor();
        }
        
        // Subclasses can override virtual methods on the parent class. When it comes to polymorphism
        // that means, that if we store a Dragon instance in a VirtualPet variable, and we call
        // DrawAvatar, the Dragon's definition of DrawAvatar will run. If we don't use virutal + override,
        // then the VirtualPet's definition of DrawAvatar would run.
        public override void DrawAvatar()
        {
            ForegroundColor = Color;
            WriteLine(Avatars.Dragon);
            ResetColor();
        }
    }
}
