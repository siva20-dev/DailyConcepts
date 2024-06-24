using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.ExplicitInterfaceImplementation
{
    #region Explicit Interface Implementation Example
    interface I1
    {
       void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    public class Application : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
    }
    #endregion

    #region Default and Explicit Implementation
    interface I3
    {
        void InterfaceMethod1();
    }

    interface I4
    {
        void InterfaceMethod1();
    }

    public class Application1 : I3, I4
    {
        public void InterfaceMethod1()
        {
            Console.WriteLine("I3 Interface Method");
        }

        void I4.InterfaceMethod1()
        {
            Console.WriteLine("I4 Interface Method");
        }
    }
    #endregion
}
