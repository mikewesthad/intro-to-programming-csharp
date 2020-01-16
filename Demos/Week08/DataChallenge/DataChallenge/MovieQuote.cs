using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataChallenge
{
    class MovieQuote
    {
        string Text;
        string Author;
        int Date;

        public MovieQuote(string text, string author, int date)
        {
            Text = text;
            Author = author;
            Date = date;
        }

        public void Display()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\n\"{Text}\"");
            Console.WriteLine($"  — {Author} ({Date})\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
