using System;
using static System.Console;

namespace LoopsDemo
{
    class Program
    {
        // Note: we don't normally want to jam all our code inside of Main. We want to get in the 
        // habit of put most of our code in custom classes. This demo is an exception because
        // it's not really a functional application!
        static void Main(string[] args)
        {
            // New string formatting options! We can use one of the WriteLine method overloads
            // to insert variables into a string
            //string name = "Alex";
            //string message = "Good question.";
            //WriteLine("{0} {1}", name, message);

            // Simple loops/
            CountUpWithWhileLoop();
            WriteLine("\n==============\n");
            CountDownWhileLoop();
            WriteLine("\n==============\n");
            CountUpWithForLoop();
            WriteLine("\n==============\n");
            CountByFives();
            WriteLine("\n==============\n");

            // A more useful example of a loop.
            EnterShop();

            WriteLine("Press any key to exit.");
            ReadKey(true);
        }

        // Count up from 0 to 4 with a while loop.
        static void CountUpWithWhileLoop()
        {
            int count = 0;
            while (count < 5)
            {
                WriteLine("The count is {0}!", count);
                count++;
            }
        }

        // Count down from 5 to 1 with a while loop.
        static void CountDownWhileLoop()
        {
            int count = 5;
            while (count > 0)
            {
                WriteLine("Tick... {0}", count);
                count--;
            }
            WriteLine("Boom.");
        }

        // Count up from 1 to 4 with a for loop.
        static void CountUpWithForLoop()
        {
            WriteLine("Trying to fall asleep.");
            for (int i = 1; i < 5; i++)
            {
                WriteLine("Counting sheep... {0} sheep", i);
            }
            WriteLine("Zzzzzz...");
        }

        // Challenge: count from 5 to 25 by 5s (e.g. 5, 10, 15, 20, 25).
        static void CountByFives()
        {
            for (int num = 5; num <= 25; num += 5)
            {
                WriteLine("Counting by 5s {0}", num);
            }
        }

        // A more functional example of how you could use a loop in the wild.
        static void EnterShop()
        {
            bool isResponseValid;
            string response;
            WriteLine("====== Welcome to the Shop ======");
            do
            {
                WriteLine("I currently have:");
                WriteLine("\tA) Apple\n\tB) Banana");
                response = ReadLine().ToUpper();
                if (response == "A" || response == "B")
                {
                    isResponseValid = true;
                }
                else
                {
                    WriteLine("I don't have {0}, pick something else.", response);
                    isResponseValid = false;
                }
            } while (isResponseValid == false);

            // The loop condition could have been shorter using the not operator: 
            //  while (!isResponseValid)

            if (response == "A")
            {
                WriteLine("You purchased an apple.");
            }
            else if (response == "B")
            {
                WriteLine("You purchased a banana.");
            }
        }
    }
}
