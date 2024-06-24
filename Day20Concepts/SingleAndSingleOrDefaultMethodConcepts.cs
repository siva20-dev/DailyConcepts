using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.SingleAndSingleOrDefaultMethodConcepts
{
    public class SingleAndSingleOrDefaultMethod
    {
        public void MethodSyntaxExample1()
        {
            List<int> numbers = new List<int>() { };

            var methodSyntax2 = numbers.SingleOrDefault();
            Console.WriteLine(methodSyntax2);

            var methodSyntax = numbers.Single();
        }

        public void MethodSyntaxExample2()
        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7 };

            var methodSyntax = numbers.Where(number => number <2).Single();

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var methodSyntax = numbers.Where(number => number > 7).SingleOrDefault();

            Console.WriteLine(methodSyntax);
        }

        public void MixedSyntaxExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var mixedSyntax = (from number in numbers
                               where number < 2
                               select number).Single();

            Console.WriteLine(mixedSyntax);
        }

        public void MixedSyntaxExample2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var mixedSyntax = (from number in numbers
                               where number > 7
                               select number).SingleOrDefault();

            Console.WriteLine(mixedSyntax);
        }
    }
}
