using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.DiamondProblem
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Class B Overriding Print() Method");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Class C Overriding Print() Method");
        }
    }
}

