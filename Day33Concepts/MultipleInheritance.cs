using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.MultipleInheritance
{
    interface IA
    {
        void AMethod();
    }

    public class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A method");
        }
    }

    interface IB
    {
        void BMethod();
    }

    public class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B method");
        }
    }

    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }
}
