using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsClass
{
    class Program
    {
        class Student
        {
            public string FirstName  { get; set; }

            public string LastName  { get; set; }

            public int Age { get; set; }

            public string Town { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input !="end")
            {
                string[] line = input.Split();

                string first = line[0];
                string last = line[1];
                int age = int.Parse(line[2]);
                string town = line[3];

                Student student = new Student();
                {
                    student.FirstName = first;
                    student.LastName = last;
                    student.Age = age;
                    student.Town = town;
                }
                students.Add(student);
                input = Console.ReadLine();
            }

            string filteredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Town==filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
                              //Using Linq 100/100
            //List<Student> filteredStudent = students.Where(s => s.Town == filteredCity).ToList();
            //
            //foreach (Student student in filteredStudent)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} year old.");
            //}
        }
    }
}
