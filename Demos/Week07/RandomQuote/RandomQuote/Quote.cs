using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomQuote
{
    class Quote
    {
        string Text;
        string Author;

        public Quote(string text, string author)
        {
            Text = text;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\"{0}\"", Text);
            Console.WriteLine("  — {0}\n", Author);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}
