using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week11_Conditionals
{
    static class Game
    {
        public static void Run()
        {
            WriteLine("Boolean Logic Game\n");

            Player player1 = new Player();
            player1.LoadSaveData("Data/Player1Save.txt");
            player1.PrintPlayerStats();
            WriteLine();
            CheckPlayerStats(player1);

            WriteLine();

            Player player2 = new Player();
            player2.LoadSaveData("Data/Player2Save.txt");
            player2.PrintPlayerStats();
            WriteLine();
            CheckPlayerStats(player2);

            // Demo conditionals based on slides:

            // Checking if a score is between two values.
            //int score = 10;
            //if (score >= 10 && score <= 20)
            //{
            //    WriteLine("The score is in range.");
            //}

            // Checking if the player has enough illumination to enter a dark area:
            //bool hasFlashlight = false;
            //bool hasLantern = false;
            //if (hasFlashlight || hasLantern)
            //{
            //    WriteLine("The player can pass the dark tunnel");
            //}

            WriteLine("\nPress any key to exit...");
            ReadKey();
        }

        static void CheckPlayerStats(Player player)
        {
            WriteLine($"~~ Feedback for Player {player.Name} ~~");

            // 1) If the player hasn't beaten the game, print out an encouraging message:
            if (!player.HasBeatenGame)
            {
                WriteLine("> You are getting closer - keep trying!");
            }

            // 2) If the player has beaten the game with a score < 10, print out a message telling
            //    them to play again and try to get a top score:
            if (player.Score < 10 && player.HasBeatenGame)
            {
                WriteLine("> You got an OK score, why don't you try again?");
            }
            // Condition can also be written as as nested conditionals: 
            //  if (player.HasBeatenGame)
            //  {
            //      if (player.Score < 10)
            //      {
            //          ...
            //      }
            //  }

            // 3) If the player has a shield, or a defense level greater than 5, then tell them they
            //    are ready for the boss.
            if (player.HasShield || player.Defense > 5)
            {
                WriteLine("> You are pretty tough. You are ready for the boss.");
            }

            // 4) If the player is a pacifist, or they have attack and defense both greater than 3,
            //    then tell them they are ready for final level.
            if (player.IsPacifist || (player.Attack > 3 && player.Defense > 3))
            {
                WriteLine("> You are ready for the final level");
            }
        }
    }
}
