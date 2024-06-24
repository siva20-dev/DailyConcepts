using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.RefAndOutConcepts
{
    public class RefAndOutConcept
    {
        public static void SomeFunction(ref int InsideVar)
        {
            InsideVar = InsideVar + 10;
        }

        public static void SomeFunction1(out int InsideVar1)
        {
            InsideVar1 = 0;
            InsideVar1 = InsideVar1 + 10;
        }

        public static void ReferenceParaMeterExample()
        {
            int OutSideVariable = 20;
            RefAndOutConcept.SomeFunction(ref OutSideVariable);

            Console.WriteLine(OutSideVariable);
        }

        public static void OutParaMeterExample()
        {
            int OutSideVariable2 = 20;
            RefAndOutConcept.SomeFunction1(out OutSideVariable2);

            Console.WriteLine(OutSideVariable2);
        }
    }
}
