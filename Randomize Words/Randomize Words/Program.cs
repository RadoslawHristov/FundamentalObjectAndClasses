using System;

namespace Randomize_Words
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < word.Length - 1; i++)
            {
                int position = rnd.Next(0, word.Length);
                string words = word[i];
                word[i] = word[position];
                word[position] = words;
            }

            Console.WriteLine(string.Join(Environment.NewLine, word));
        }
    }
}
