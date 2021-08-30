using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new List<People>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0]=="End")
                {
                    break;
                }
                
                People people = new People();
                people.Name = input[0];
                people.IdNumber = input[1];
                people.Age = int.Parse(input[2]);

                human.Add(people);
            }

           

            foreach (var People in human.OrderBy(People=>People.Age))
            {
                Console.WriteLine($"{People.Name} with ID: {People.IdNumber} is {People.Age} years old.");
            }

        }
        class People
        {
            public string Name { get; set; }

            public string IdNumber { get; set; }

            public int Age { get; set; }
        }
    }
}
