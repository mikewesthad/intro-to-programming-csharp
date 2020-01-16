using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ListsDemo
{
    class PartyManager
    {
        static public void BuildParty()
        {
            BuildStringParty();

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }

        static void BuildClassParty()
        {
            // Note: we didn't get to do this in class yet, so it's not implemented!
        }

        static void BuildStringParty()
        {
            List<string> party = new List<string>();

            // Count is total number of elements.
            // Capacity is the total it can store without resizing.
            WriteLine("The party {0} members", party.Count);
            WriteLine("The party has a capacity of {0}", party.Capacity);

            // You can use Add to append a new element to the end of the list.
            party.Add("Pikachu");

            // Your turn: add someone to your list.
            // See how both the count and capacity jump up after the next lines?
            WriteLine("The party {0} members", party.Count);
            WriteLine("The party has a capacity of {0}", party.Capacity);

            party.Add("Luxray");

            WriteLine("The party {0} members", party.Count);
            WriteLine("The party has a capacity of {0}", party.Capacity);

            // You can use Insert to place an element at a specific spot in the list.
            party.Insert(1, "Ditto");

            WriteLine("The party {0} members", party.Count);
            WriteLine("The party has a capacity of {0}", party.Capacity);

            WriteLine("\n--- The Party ---");
            for (int i = 0; i < party.Count; i++)
            {
                string currentMember = party[i];
                WriteLine("  Party member {0} : {1}", i, currentMember);
            }

            // This will remove the element at the specified index in the list.
            party.RemoveAt(0);

            // This is code duplication. We were just getting something working and
            // not worrying about code architecture. What would be a better way to do this?
            WriteLine("\n--- The Party ---");
            for (int i = 0; i < party.Count; i++)
            {
                string currentMember = party[i];
                WriteLine("  Party member {0} : {1}", i, currentMember);
            }

            // You can remove an element by passing in the value of the element.
            // This will remove the first thing that it finds that is equal (==) to what
            // you pass in.
            party.Remove("Luxray");

            // More duplication!
            WriteLine("\n--- The Party ---");
            for (int i = 0; i < party.Count; i++)
            {
                string currentMember = party[i];
                WriteLine("  Party member {0} : {1}", i, currentMember);
            }

            // Nuke everything - remove all items from the list.
            party.Clear();
        }
    }
}
