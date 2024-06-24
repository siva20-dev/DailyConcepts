using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.DiamondProblem
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    //public class D : B, C
    //{

    //}
}
