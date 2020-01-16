using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class TriviaItem
    {
        public string Question;
        public string Answer;

        public TriviaItem(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
