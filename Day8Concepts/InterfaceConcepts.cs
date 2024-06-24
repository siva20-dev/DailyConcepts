using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.InterfaceConcepts
{
    interface ICustomer
    {
        void Print();
    }

    public class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Interface print Method");
        }
    }

    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer1 : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }
}

