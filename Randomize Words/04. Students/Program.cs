using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int stud = int.Parse(Console.ReadLine());

            List<Study> allstudent = new List<Study>();
            for (int i = 0; i < stud; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstname = input[0];
                string lastname = input[1];
                double grade = double.Parse(input[2]);

                allstudent.Add(new Study(firstname,lastname,grade));
            }

            allstudent = allstudent.OrderByDescending(s => s.Grade ).ToList();

            foreach (var study in allstudent)
            {
                Console.WriteLine(study);   
            }
        }
    }
}
