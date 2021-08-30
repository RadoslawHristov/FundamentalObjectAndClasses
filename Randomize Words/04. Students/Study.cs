using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Students
{
    class Study
    {
        public Study(string firstname,string lastname,double grade)
        {
            FirstName = firstname;
            Lastname = lastname;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Lastname}: {Grade:f2}";
        }
    }
}
