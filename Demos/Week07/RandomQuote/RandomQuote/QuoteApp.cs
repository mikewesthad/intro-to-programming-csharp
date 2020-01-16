/*
 * Famous Quotes App
 * 
 * Quotes are sourced from: 
 *  https://www.coburgbanks.co.uk/blog/friday-funnies/50-funny-motivational-quotes/
 *  
 * Challenges:
 *  > Display all the quotes.
 *  > Display a random quote.
 *  > Give the user a menu of option, so that they can choose to either see all
 *    the quotes, or just get one random quote.
 *  > Give the user the ability to add a new quote to the file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace RandomQuote
{
    class QuoteApp
    {
        static string QuotesFilePath = "FamousQuotes.txt";
        static List<Quote> FamousQuotes;

        public static void Run()
        {
            Title = "Random Quote of the Day";

            LoadQuotes();
            //DisplayAllQuotes();
            DisplayRandomQuote();

            WaitForKey();
        }

        static void LoadQuotes()
        {
            FamousQuotes = new List<Quote>();
            string[] lines = File.ReadAllLines(QuotesFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string author = parts[0];
                string text = parts[1];
                Quote quote = new Quote(text, author);
                FamousQuotes.Add(quote);
            }
        }

        static void DisplayAllQuotes()
        {
            foreach (Quote q in FamousQuotes)
            {
                q.Display();
            }
        }

        static void DisplayRandomQuote()
        {
            Random rng = new Random();
            int i = rng.Next(0, FamousQuotes.Count);
            Quote quote = FamousQuotes[i];
            quote.Display();
        }

        static void WaitForKey(string text = "(Press any key)")
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine(text);
            ReadKey(true);
        }
    }
}
