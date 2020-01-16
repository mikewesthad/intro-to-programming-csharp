using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TriviaGame
{
    class Game
    {
        public string Title = "Trivia Quest";
        public string Description = "Battle your friends for the top score in silly trivia.";

        public void Play()
        {
            // Trick to set the background color for the whole console using Clear.
            BackgroundColor = ConsoleColor.White;
            Clear();

            ForegroundColor = ConsoleColor.Blue;

            // Display the welcome screen for the game.
            WriteLine("Welcome to " + Title);
            WriteLine(Description);

            // Create the player and welcome them.
            Write("What is your name: ");
            string playerName = ReadLine();
            Player currentPlayer = new Player(playerName);
            WriteLine("Welcome to " + Title + ", " + currentPlayer.Name + "!");

            // Create a question.
            string catPrompt = "Cats have more bones than humans - true or false?";
            string catAnswer = "true";
            TriviaItem catQuestion = new TriviaItem(catPrompt, catAnswer);

            WriteLine("Question 1");
            WriteLine(catQuestion.Question);
            string catPlayerResponse = ReadLine();

            // Conditionals allow us to use branching logic.
            if (catPlayerResponse == catQuestion.Answer)
            {
                WriteLine("You got it right!");
            } 
            else
            {
                WriteLine("Try again.");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
