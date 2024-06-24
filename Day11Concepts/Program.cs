using System;
using System.Linq;
using Day11Concepts.Arrays;
using Day11Concepts.ComparingArray;
using Day11Concepts.GenericsConcepts;

namespace Day11Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planets.ArrayExample1();
            Planets.ArrayClassExampleMethods();

            WithoutUsingGenerics();

            MethodGenericExample();

            ClassGenericExample();

            Week.DaysofWeek();
        }

        static void WithoutUsingGenerics()
        {
            bool equal = Calculator.AreEqual(1, 2);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        static void MethodGenericExample()
        {
            bool equal1 = Calculator.AreEqual1<int>(10, 10);

            if (equal1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }

        static void ClassGenericExample()
        {
            bool equal2 = Calculator1<int>.AreEqual2(10, 10);

            if (equal2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
