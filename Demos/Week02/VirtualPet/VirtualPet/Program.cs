using static System.Console;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Virtual Pet");

            // We can create a pet and set its public fields manually.
            VirtualPet junior = new VirtualPet();
            junior.Name = "Junior";
            junior.AgeInDays = 7;
            junior.Greet();

            // The power of classes is that we can now create many unique virtual pets from the 
            // same template.
            VirtualPet steph = new VirtualPet();
            steph.Name = "Steph";
            steph.AgeInDays = 73;
            steph.Greet();

            // We can use our fancy constructor to streamline the process of creating a pet -
            // no need for accessing the Name/Mood/AgeInDays fields directly.
            VirtualPet ruffles = new VirtualPet("Ruffles", "Chipper", 30);
            ruffles.Greet();

            // Now we can create a virtual pet for the player:
            VirtualPet playersPet = new VirtualPet();
            WriteLine("Please name your pet:");
            playersPet.Name = ReadLine();
            playersPet.Greet();

            ReadKey();
        }
    }
}
