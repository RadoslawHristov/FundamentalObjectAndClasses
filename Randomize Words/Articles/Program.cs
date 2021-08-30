using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int n = int.Parse(Console.ReadLine());

            Articles articles = new Articles(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] splited = Console.ReadLine().Split(": ");
                string names = splited[0];
                string value = splited[1];

                if (names=="Edit")
                {
                    //articles.//Edit(value);
                }

                if (names== "ChangeAuthor")
                {
                    //articles.//ChangeAuthor(value);
                }

                if (names== "Rename")
                {
                    //articles.//Rename(value);
                }
            }

            Console.WriteLine(articles);
        }
    }
}
