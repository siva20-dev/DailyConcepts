using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.ExplicitInterfaceImplementations
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I3
    {
        void InterfaceMethod();
    }

    public class ExplicitInterfaceImplementation : I1, I3
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I3.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
    }
}
