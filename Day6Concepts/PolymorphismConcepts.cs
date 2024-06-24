using Day6Concepts.inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.polymorphism
{
    #region Polymorphism Example
    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "-Parttime");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "-Fulltime");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "-Temporary");
        }
    }
    #endregion
}
