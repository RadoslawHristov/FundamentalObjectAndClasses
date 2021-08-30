using System;
using System.Collections.Generic;

namespace Advertisement_Message
{

    class Program
    {
        static void Main(string[] args)
        {
            Randomgenerator word = new Randomgenerator(new List<string>()
            {
                "Excellent product.", "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                 "Exceptional product.",
                 "I can’t live without this product."
            });

            Randomgenerator events = new Randomgenerator(new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            });

            Randomgenerator authors = new Randomgenerator(new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            });

            Randomgenerator cities = new Randomgenerator(new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            });


            Console.WriteLine($"{word.GetWord()} {events.GetWord()} {authors.GetWord()} - {cities.GetWord()}");

        }
    }
}