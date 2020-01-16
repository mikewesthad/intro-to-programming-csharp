/*
 * Journal App
 * 
 * Challenges:
 *  > Read from the file and display the contents.
 *  > Let the user clear the file.
 *  > Let the user add a line to the file.
 *  > Display a menu of options so the user can choose which action to take.
 *  > Let the user add multiple lines to a file in one action.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Journal
{
    class JournalApp
    {
        static string TitleArt = @"(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";
        static string JournalFilePath = "Journal.txt";

        public static void Run()
        {
            BackgroundColor = ConsoleColor.White;
            Clear();

            Title = "Journal App";
            ForegroundColor = ConsoleColor.Black;
            WriteLine(TitleArt);
            WriteLine("Welcome to the only journaling app you'll ever need!");
            WaitForKey();

            string choice;
            do
            {
                choice = GetChoice();
                switch (choice)
                {
                    case "1":
                        DisplayAllContents();
                        break;
                    case "2":
                        ClearFile();
                        break;
                    case "3":
                        AppendText();
                        break;
                    default:
                        break;
                }

                // You can use a switch or an if-else if-else structure:
                //if (choice == "1")
                //{
                //    DisplayAllContents();
                //}
                //else if (choice == "2")
                //{
                //    ClearFile();
                //}
                //else if (choice == "3")
                //{
                //    AppendText();
                //}
            } while (choice != "4");
            
            WriteLine("\n\nArt from: https://www.asciiart.eu/books/books");
            WaitForKey("Thanks for using the app. Press any key to exit.");
        }

        // Ask the player to choose one of four possible options. Keep asking until they pick
        // a valid choice.
        static string GetChoice()
        {
            bool isChoiceValid = false;
            string choice = "";
            while (isChoiceValid == false)
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                WriteLine("What would you like to do?");
                WriteLine(" > 1 - Read the journal.");
                WriteLine(" > 2 - Clear the journal.");
                WriteLine(" > 3 - Add to the journal.");
                WriteLine(" > 4 - Quit.");

                ForegroundColor = ConsoleColor.DarkBlue;
                choice = ReadLine().Trim();

                // The paren are optional here because of order of operations.
                if ((choice == "1") || (choice == "2") || (choice == "3") || (choice == "4"))
                {
                    isChoiceValid = true;
                }
                else
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("\"{0}\" is not a valid choice.", choice);
                    WaitForKey();
                }
            }
            return choice;
        }

        static void DisplayAllContents()
        {
            ForegroundColor = ConsoleColor.Magenta;
            string contents = File.ReadAllText(JournalFilePath);
            WriteLine("==== The Journal Contents ====");
            WriteLine(contents);
            WriteLine("==============================");
            WaitForKey();
        }

        static void ClearFile()
        {
            File.WriteAllText(JournalFilePath, "");
            ForegroundColor = ConsoleColor.Black;
            WriteLine("The journal has been erased!");
            WaitForKey();
        }

        static void AppendText()
        {
            ForegroundColor = ConsoleColor.Black;
            WriteLine("What would you like add to the journal?");
            ForegroundColor = ConsoleColor.DarkMagenta;
            string newLine = ReadLine();
            File.AppendAllText(JournalFilePath, newLine + "\n");
            ForegroundColor = ConsoleColor.Black;
            WriteLine("The journal has been modified!");
            WaitForKey();

            // More advanced, writing multiple lines:
            //ForegroundColor = ConsoleColor.Black;
            //WriteLine("\nWhat would you like to add? Type EXIT and press enter to stop: ");
            //ForegroundColor = ConsoleColor.DarkMagenta;
            //string contents = "";
            //bool shouldContinueReading = true;
            //while (shouldContinueReading)
            //{
            //    string line = ReadLine();
            //    if (line.ToLower().Trim() == "exit")
            //    {
            //        shouldContinueReading = false;
            //    }
            //    else
            //    {
            //        contents += line + "\n";
            //    }
            //}
            //File.AppendAllText(JournalFilePath, contents);
            //ForegroundColor = ConsoleColor.Black;
            //WriteLine("\nAdded!");
            //WaitForKey();
        }

        static void WaitForKey(string text = "(Press any key)")
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine(text);
            ReadKey(true);
        }
    }
}
