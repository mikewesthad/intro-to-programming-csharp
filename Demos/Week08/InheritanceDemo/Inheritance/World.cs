using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    class World
    {
        public World()
        {
            // This should be familiar at this point - we're just creating an instance of 
            // a class.
            VirtualPet junior = new VirtualPet("Junior", 6, "Hampster", 2);
            junior.Greet();

            WriteLine();

            // This is new! Dragon inherits all the public and protected fields and methods
            // of VirtualPet.
            Dragon bahumat = new Dragon("Bahumat", 400, "Lots of gold", 20);
            bahumat.Greet(); // This is a method declared in VirtualPet.
            bahumat.Fly();

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
