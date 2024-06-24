using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.AbstractClassesConcepts
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class Application : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
