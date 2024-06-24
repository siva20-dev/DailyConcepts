using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.PartitionOperatorTakeMethod
{
    public class TakeMethod
    {
        public void MethodSyntaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }

            var methodSyntax2 = numbers.Where(num=> num > 3).Take(5).ToArray();

            foreach (var number in methodSyntax2)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSyntaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mixedSyntax = (from num in numbers
                               select num).Take(5).ToArray();

            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }

            var mixedSyntax2 = (from num in numbers
                                where num > 7
                               select num).Take(3).ToArray();

            foreach (var number in mixedSyntax2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
