using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.MultipleInheritance
{
    interface IA
    {
        void AProcess();
    }

    class A:IA
    {
        public void AProcess() 
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BProcess();
    }

    class B : IB
    {
        public void BProcess()
        {
            Console.WriteLine("B");
        }
    }

    class AB: IA,IB
    {
        A a = new A();
        B b = new B();
        public void AProcess()
        {
            a.AProcess();
        }
        public void BProcess()
        {
            b.BProcess();
        }
    }
}
