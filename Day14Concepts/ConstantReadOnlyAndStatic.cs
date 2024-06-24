using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.ConstantReadOnlyAndStatic
{
    public class ConstantReadOnlyAndStaticConcepts
    {
        readonly int number1;

        static int number2 = 0;

        public ConstantReadOnlyAndStaticConcepts()
        {
            number1 = 10;
            Console.WriteLine(number1);

            number2++;
            Console.WriteLine("For first object: "+ number2);
        }

        public static void ConstantExample()
        {
            const int number = 100;

            Console.WriteLine(number);
        }

        public static void StaticAndReadonlyConceptsExample()
        {
            ConstantReadOnlyAndStaticConcepts.ConstantExample();

            ConstantReadOnlyAndStaticConcepts p = new ConstantReadOnlyAndStaticConcepts();

            ConstantReadOnlyAndStaticConcepts p1 = new ConstantReadOnlyAndStaticConcepts();
            ConstantReadOnlyAndStaticConcepts p2 = new ConstantReadOnlyAndStaticConcepts();
            ConstantReadOnlyAndStaticConcepts p3 = new ConstantReadOnlyAndStaticConcepts();
            ConstantReadOnlyAndStaticConcepts p4 = new ConstantReadOnlyAndStaticConcepts();
        }
    }
}
