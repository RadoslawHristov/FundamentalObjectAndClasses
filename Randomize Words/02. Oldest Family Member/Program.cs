using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < lines; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var person = new Person(line[0], int.Parse(line[1]));

            family.AddMember(person);
        }

        var oldestMember = family.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class Family
    {
        private List<Person> membersList;

        public List<Person> MembersList
        {
            get { return membersList; }
            set { membersList = value; }
        }

        public Family()
        {
            this.MembersList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.MembersList.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.membersList.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}