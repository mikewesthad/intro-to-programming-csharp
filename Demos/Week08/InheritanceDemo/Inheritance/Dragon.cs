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

        // When you have a constructor on a derived class, it implicitly calls the base
        // class constructor. If we want to control which constructor it uses, we can
        // use the following syntax, where we call the 4-parameter version of the VirtualPet
        // constructor.
        public Dragon(string name, int age, string treasure, double wingSpan)
            : base(name, age, "Dragon", wingSpan * 100)
        {
            Treasure = treasure;
            WingSpan = wingSpan;
        }

        public void Fly()
        {
            WriteLine($"{Name} is now flying");
        }
    }
}
