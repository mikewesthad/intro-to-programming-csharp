using System;
using static System.Console;

namespace VirtualPet
{
    class VirtualPet
    {
        // Fields - variables declared within a class.
        // Naming convention: PascalCase.
        // [access modifier] [type] [identifier] [initializer]
        public string Name;
        public string Mood;
        public int AgeInDays;
        public bool IsAwake = false;
        private double EnergyLevel = 1.0;

        // A constructor that takes no parameters and sets some of the fields to default values.
        public VirtualPet()
        {
            Name = "Unknown";
            Mood = "Unknown";
            AgeInDays = 0;
        }

        // A constructor that takes three parameters and uses them to set the fields.
        public VirtualPet(string name, string mood, int ageInDays)
        {
            Name = name;
            Mood = mood;
            AgeInDays = ageInDays;
        }

        public void Greet()
        {
            WriteLine("Why hello, my name is " + Name + ".");
            WriteLine("I am " + AgeInDays + " days old.");
        }
    }
}
