using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.inheritance
{
    #region Inheritance Example1
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
        public float hourlySalary;
    }
    #endregion

    #region Inheritance Example2
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor called");
        }

        public ParentClass(string message)
        { 
            Console.WriteLine(message); 
        } 
    }

    public class ChildClass : ParentClass
    {
        public ChildClass(): base("Derived class controlling Parent class constructor")
        {
            Console.WriteLine("Child Class Constructor called");
        }
    }
    #endregion
}
