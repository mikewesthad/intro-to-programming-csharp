/*
 * Movie Quotes App
 *   
 * Challenges:
 *  > Read in the text from "MovieQuotes.txt" and display it to the screen.
 *  > Comment out your previous code. Now, test out the MovieQuote class by making an instance yourself 
 *    (pick your favorite quote) and display it to the screen.
 *  > Comment out your previous code. Now, loop over the text file and construct MovieQuote instances 
 *    for each movie quote. Hint: the data is spread out over multiple lines... how could you design 
 *    a loop that jumps to the next movie quote each iteration?
 *  > Display a random movie quote.
 *  > Give the user the ability to add a new quote to the file.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace DataChallenge
{
    class MovieQuoteApp
    {
        static string QuotesFilePath = "MovieQuotes.txt";
        static List<MovieQuote> Quotes;

        public static void Run()
        {
            Title = "Movie Quote of the Day";

            // Step 1: Printing out the contents.
            //string contents = File.ReadAllText(QuotesFilePath);
            //WriteLine(contents);

            // Step 2: Making a MovieQuote manually.
            //MovieQuote buzzQuote = new MovieQuote("To Infinity and Beyond!", "Toy Story", 1995);
            //buzzQuote.Display();

            LoadAllQuotes();

            WaitForKey();
        }

        static void LoadAllQuotes()
        {
            string[] lines = File.ReadAllLines(QuotesFilePath);

            for (int i = 0; i < lines.Length; i+= 3)
            {
                string quoteText = lines[i];
                string[] parts = lines[i + 1].Split(',');
                string movie = parts[0];
                int year = Convert.ToInt32(parts[1]);
                MovieQuote quote = new MovieQuote(quoteText, movie, year);
                quote.Display();
            }

            Quotes = new List<MovieQuote>();
        }

        static void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("(Press any key)");
            ReadKey(true);
        }

        static string PromptForString(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }
    }
}
