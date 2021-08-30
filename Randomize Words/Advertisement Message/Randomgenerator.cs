using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisement_Message
{
    class Randomgenerator
    {
        public Randomgenerator(List<string> word)
        {
            Word = word;
        }


        public List<string> Word { get; set; }

        public string GetWord()
        {
            Random random = new Random();
            return Word[random.Next(Word.Count)];
        }


    }
}
