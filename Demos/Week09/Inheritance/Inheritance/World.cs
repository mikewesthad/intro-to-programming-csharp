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
            // This should be familiar at this point - we're just creating an instance of a class.
            VirtualPet junior = new VirtualPet("Junior", ConsoleColor.White, "Hampster", 2);
            //junior.Greet();

            // This is new! Dragon inherits all the public and protected fields and methods of 
            // VirtualPet.
            Dragon bahumat = new Dragon("Bahumat", ConsoleColor.Red, "Lots of gold", 20);
            // This is a method declared in VirtualPet. Dragon can use it because it inherits from
            // VirtualPet.
            //bahumat.Greet();
            //bahumat.Fly();

            Giraffe geoffrey = new Giraffe("Geoffrey", ConsoleColor.DarkYellow, 2000, 5.5);

            // Inheritance is an "is a" relationship. Geoffry the Giraffe "is a" VirtualPet. The present
            // that we are giving Geoffrey is a "has a" relationship and is often called composition. 
            // Geoffrey owns the present. Other examples you might see: a player "has a" item, a
            // superhero "has a" superpower (or superpowers).
            Present geoffreyPresent = new Present("Box of Lego", 1, "Medium");
            geoffrey.TakePresent(geoffreyPresent);
            //geoffrey.Greet();

            // Polymorphism in action! You can store a Dragon in a VirtualPet variable.
            VirtualPet smaug = new Dragon("Smaug", ConsoleColor.DarkRed, "Dwarven gold", 40);
            //smaug.Greet();
            //smaug.DrawAvatar();

            // All classes inherit from Object, which provides ToString().
            //Console.WriteLine(smaug.ToString());

            // Polymorphism in action again! We can loop over all our animals and run methods
            // that they all share in common because they inherit from VirtualPet.
            VirtualPet[] pets = { junior, bahumat, geoffrey, smaug };
            for(int i = 0; i < pets.Length; i++)
            {
                VirtualPet pet = pets[i];
                pet.Greet();
                pet.DrawAvatar();
                WriteLine();
            }
            
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
