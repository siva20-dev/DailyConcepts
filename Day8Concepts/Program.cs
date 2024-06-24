using System;
using Day8Concepts.InterfaceConcepts;
using Day8Concepts.ExplicitInterfaceImplementation;
using abstractClasses = Day8Concepts.AbstractClassesConcepts;
using Day8Concepts.MultipleInheritance;

namespace Day8Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceExample();

            ExplicitInterfaceImplementation();

            DefaultInterfaceImplemetation();

            AbstractclassesExample();

            MultipleInheritanceProblem();
        }

        static void InterfaceExample()
        {
            Customer C1 = new Customer();
            C1.Print();

            Customer1 C2 = new Customer1();
            C2.Print1();
            C2.Print2();

            ICustomer1 C3 = new Customer1();
            C3.Print1();
        }

        static void ExplicitInterfaceImplementation()
        {
            //Application A = new Application();
            //((I1)A).InterfaceMethod();
            //((I2)A).InterfaceMethod();
            
            //or

            I1 i1 = new Application();
            I2 i2 = new Application();
            
            i1.InterfaceMethod();
            i2.InterfaceMethod();
        }

        static void DefaultInterfaceImplemetation()
        {
            Application1 A1 = new Application1();
            A1.InterfaceMethod1();
            ((I4)A1).InterfaceMethod1();
        }

        static void AbstractclassesExample()
        {
            abstractClasses.Application A = new abstractClasses.Application();
            A.Print();
        }

        
        static void MultipleInheritanceProblem()
        {
            AB ab = new AB();
            ab.AProcess();
            ab.BProcess();
        }
    }
}
