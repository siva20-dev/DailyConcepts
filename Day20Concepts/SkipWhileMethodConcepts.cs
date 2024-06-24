using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.SkipWhileMethodConcepts
{
    public class SkipWhileMethod
    {
        public void MethodSyntaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var methodSyntax = numbers.SkipWhile(num => num < 6).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSyntaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10,7 };

            var mixedSyntax = (from num in numbers
                               select num).SkipWhile(num => num < 8).ToList();

            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSytaxExample2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.SkipWhile(name => name.Length > 4).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSytaxExample3()
        {
            List<string> names = new List<string>() { "Kim", "John", "St", "Tom", "Nithish" };

            var methodSyntax = names.SkipWhile((value, index) => value.Length > index).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }
}
