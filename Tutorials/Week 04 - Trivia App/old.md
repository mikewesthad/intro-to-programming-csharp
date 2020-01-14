

### Creating the Game

Next, create a new class and name it "Game" (in the toolbar, click on "Project" and then click on "Add Class"). Add the properties and methods from the UML diagram. Your code might look something like this:

```cs
using static System.Console;

namespace Week2_TriviaApp
{
    class Game
    {
        private string Name = "Terrific Trivia";
        private string Description = "A trivia game to test your knowledge of useless things!";

        private void Play()
        {
          Title = Name;
          
          // Trick to set the background for everything, not just the text.
          BackgroundColor = ConsoleColor.White;
          Clear();

          ForegroundColor = ConsoleColor.DarkMagenta;
          WriteLine("Welcome to " + Name + "!");
          WriteLine(Description);

          // The logic that runs the rest of the game will go here...

          WriteLine("\nThanks for playing! Come back soon.");
          WriteLine("Press any key to exit...");
          ReadKey();
        }
    }
}
```

Some important points:
- The `+` operator here is **concatenating** three strings together when we type `"Welcome to " + Name + "!"`. When you use the `+` operator with two numbers, it adds the numbers together.
- `using static System.Console;` lets us use the Console class from the System **namespace** without needing to prefix every line with `Console.` or `System.Console.` (e.g. `Title` instead of `Console.Title`).
- `ReadKey()` lets us keep the console window open after all the previous code runs.

It's important that you type this out yourself. Don't copy and paste. Once you've done that, try running your code. What happens?

Nothing! We created a class (a blueprint), but we never created an instance and used it. Head over to Program.cs, create an instance and call the `Play` method. Your `Main` method should look like this:

```cs
static void Main(string[] args)
{
    Game game = new Game();
    game.Play();
}
```

Now if you run it, you should see your console's title change and see a welcome message in the console. We'll come back to the `Play` method shortly and fill it out.

## Creating the Player and TriviaQuestion Classes

Repeat the process of creating classes for the `Player` and `TriviaQuestion` classes from our UML. The `Player` just has two fields:

```cs
namespace Week2_TriviaApp
{
    class Player
    {
        public string Name;
        public int Points = 0;
    }
}
```

The `TriviaQuestion` has two fields and a **constructor**:

```cs
namespace Week2_TriviaApp
{
    class TriviaQuestion
    {
        public string QuestionText;
        public string Answer;

        public TriviaQuestion(string questionText, string answer)
        {
            QuestionText = questionText;
            Answer = answer;
        }
    }
}
```

Run your code. What has changed?

If you guessed nothing, bingo! Again, we've created classes but we haven't used them yet.

## Filling Out the Game's `Play` Method

Let's revisit that `Play` method in the `Game` class. First, we want to capture the player's name and greet them.

```cs
class Game
{
    private string Name = "Terrific Trivia";
    private string Description = "A trivia game to test your knowledge of useless things!";

    private void Play()
    {
      // ...previous code omitted

      // Create a new Player instance
      Player player = new Player();

      // Read in the current player's name
      Write("\nWhat's your name? ");
      player.Name = ReadLine();

      // Greet the player
      WriteLine("Howdy, " + player.Name + ". Let's get to the trivia.");
      WriteLine("You are starting with " + player.Points + " points.");

      WriteLine("\nThanks for playing! Come back soon.");
      WriteLine("Press any key to exit...");
      ReadKey();
    }
}
```

Some important points:
- Why are we using `Write` instead of `WriteLine` when asking for the player's name? It lets us have the player type in their name on the same line as the question.
- The player will always have zero points in our current game, but that's okay for now.
- What's that pair of characters at the start of our string: `Write("\nWhat's your name? ");`? It's an **escape sequence** that lets us insert a newline character.

Run it. Do you have your player being greeted? Perfect! On to the first trivia item. We need to add some code below the code we just wrote:

```cs
class Game
{
    private string Name = "Terrific Trivia";
    private string Description = "A trivia game to test your knowledge of useless things!";

    private void Play()
    {
      // ...previous code omitted
      
      // Question #1 - weird fact about snails.
      string snailPrompt = "Snails have teeth - true or false?";
      string snailCorrectAnswer = "true";
      TriviaQuestion snailQuestion = new TriviaQuestion(snailPrompt, snailCorrectAnswer);
      
      // Ask the questions one at a time. Note: we'll learn how to make this much more 
      // efficient soon!
      WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Write("Question 1: " + snailQuestion.QuestionText + " ");
      string snailPlayerAnswer = ReadLine();
      WriteLine("\tYou answered: " + snailPlayerAnswer);
      WriteLine("\tThe correct answer is: " + snailQuestion.Answer);
      WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

      WriteLine("\nThanks for playing! Come back soon.");
      WriteLine("Press any key to exit...");
      ReadKey();
    }
}
```

Some important notes:
- We've used the `TriviaQuestion` **constructor** method to create our `snailQuestion` local variable.
- `\t` is another **escape sequence**. It lets us insert a tab.

If all went well, you should now have a game that prompts the player for one question and then shows them the answer. (It doesn't actually check if their answer was correct, but it's a start!)

## Extensions

Finish up the application by:
- Adding two more silly trivia questions to the application.
- Let the player know whose game they are playing. Add "By Your Name" into the title of the console window and into the welcome message at the start of the game.
- Add some more color to your game. Make the questions show up in a different color in the console from the answers.

Optionally, if you want to take this further:
- Try figuring out whether the player's guess was correct. Here are some resources to help:
  - [Conditionals](http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_07_conditional_statements/)
  - [Word Guessing Game](http://programmingisfun.com/word-guessing-game-c-console-application/)
  - [Number Guessing Game](http://programmingisfun.com/numeric-guessing-game-c-sharp-console/)
- Make it easier for your players to enter information by making both what they type in and the answer either lowercase or uppercase.
  - [ToLower()](https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=netframework-4.8)
  - [ToUpper()](https://docs.microsoft.com/en-us/dotnet/api/system.string.toupper?view=netframework-4.8)

## Uploading

When you've finished everything, save and close Visual Studio. Archive your project folder as a .zip file and upload it to canvas.