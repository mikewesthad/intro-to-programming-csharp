using System;
using static System.Console;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.Play();
        }
    }
}
