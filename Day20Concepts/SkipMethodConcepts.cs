using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.SkipMethodConcepts
{
    public class SkipMethod
    {
        public void MethodSyntaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var methodSyntax = numbers.Skip(3).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSytaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var mixedSyntax = (from num in numbers
                               select num).Skip(3).ToList();


            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSytaxExample2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.Skip(2).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSytaxExample2()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var mixedSyntax = (from num in numbers
                               where num > 4
                               select num).Skip(3).ToList();

            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }
}
