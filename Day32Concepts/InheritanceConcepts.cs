using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.InheritanceConcepts
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Base Class Constructor Called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Message from Derived class controlling Parent class")
        {
            Console.WriteLine("Derived Class Constructor Called");
        }
    }
}
