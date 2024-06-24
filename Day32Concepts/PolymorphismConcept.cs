using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Polyporphism
{
    public class Employee
    {
        public string firstName = "First Name";
        public string lastName = "Second Name";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Full Time Employee");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Part Time Employee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary Time Employee");
        }
    }
}
