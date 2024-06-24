using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodHidingConcepts
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

        public new void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }
}
