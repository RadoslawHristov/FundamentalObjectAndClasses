using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int art = int.Parse(Console.ReadLine());
            List<Articles> articales = new List<Articles>();

            for (int i = 0; i < art; i++)
            {
                // Science, planets, Bill
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                articales.Add(new Articles(title, content, author));
            }

            string comand = Console.ReadLine();

            if (comand=="title")
            {
                articales = articales.OrderBy(a => a.Title).ToList();
            }

            if (comand=="content")
            {
                articales = articales.OrderBy(a => a.Content).ToList();
            }

            if (comand=="author")
            {
                articales = articales.OrderBy(a => a.Author).ToList();
            }

            foreach (var artical in articales)
            {
                Console.WriteLine(artical);
            }
        }
    }
}
