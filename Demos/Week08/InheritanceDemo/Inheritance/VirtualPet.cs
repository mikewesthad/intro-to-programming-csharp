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
        protected int Age;
        protected string Type;
        protected double Weight;

        public VirtualPet()
        {
            // When you create a derived class from VirtualPet, unless you specify
            // a constructor (like we eventually did in Dragon), the derived class
            // will try to call the base constructor with no parameters. We added
            // this empty constructor in VirtualPet initially to address that, then 
            // we refactored Dragon to call the 4-parameter VirtualPet constructor.
            Name = "Unknown";
            Age = 0;
            Type = "Generic Pet";
            Weight = 0;
        }

        public VirtualPet(string name, int age, string type, double weight)
        {
            Name = name;
            Age = age;
            Type = type;
            Weight = weight;
        }

        public void Greet()
        {
            WriteLine($"Hi, my name is {Name}.");
            WriteLine($"I'm {Age} weeks old.");
            WriteLine($"I'm a {Type}.");
        }
    }
}
