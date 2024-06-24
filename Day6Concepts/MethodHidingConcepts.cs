using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.MethodHiding
{
    #region Method Hiding Example
    public class Employee
    {
        public string firstName;
        public string lastName;

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
        public new void PrintFullName()
        {
            //base.PrintFullName();  //Invoking a hidden base class member from derived class using base key word
            Console.WriteLine(firstName + " " + lastName + "-Contractor");
        }
    }
    #endregion
}
