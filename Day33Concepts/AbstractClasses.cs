using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.AbstractClasses
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class AbstractClassConcept : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print");
        }
    }

    public abstract class Employee
    {
        public void Print()
        {
            Console.WriteLine("Abstract Class with normal members");
        }
    }
}
