using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week4_TriviaGame
{
    class Game
    {
        public string Title = "Trivia Quest v2";
        public string Description = "Battle your friends for the top score in silly trivia.";
        public string TitleArt = @"   __       _       _                                __ 
  / /______(_)   __(_)___ _   ____ ___  _____  _____/ /_
 / __/ ___/ / | / / / __ `/  / __ `/ / / / _ \/ ___/ __/
/ /_/ /  / /| |/ / / /_/ /  / /_/ / /_/ /  __(__  ) /_  
\__/_/  /_/ |___/_/\__,_/   \__, /\__,_/\___/____/\__/  
                              /_/                       
========================================================";

        public void Play()
        {
            // Trick to set the background color for the whole console using Clear.
            BackgroundColor = ConsoleColor.White;
            Clear();

            // Display the welcome screen for the game.
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(TitleArt);

            // We can use "escape sequences" to display things like newlines and tabs by starting 
            // with a forward slash:
            // https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019
            WriteLine("\n\n");

            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("Welcome to " + Title);
            WriteLine(Description);
            
            // Create the player and welcome them.
            Write("What is your name: ");
            string playerName = ReadLine();
            Player currentPlayer = new Player(playerName);
            WriteLine("Welcome to " + Title + ", " + currentPlayer.Name + "!");

            // Create some questions for the game.
            // TODO

            // Ask the questions one at a time. Note: we'll learn how to make this much more 
            // efficient soon!
            // TODO

            // Give the player feedback on their score.
            // TODO

            WriteLine("\nThanks for playing! Come back soon.");
            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
