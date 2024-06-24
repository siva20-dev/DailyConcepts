using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperators
{
    public class SingleAndSingleOrDefault
    {
        public void Example1()
        {
            List<int> numbers = new List<int>() { };

            var methodSyntax = numbers.SingleOrDefault();
            Console.WriteLine(methodSyntax);
        }

        public void Example2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var methodSyntax = numbers.Where(number => number > 6).Single();

            Console.WriteLine(methodSyntax);
        }

        public void Example3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var methodSyntax = numbers.Where(number => number > 7).SingleOrDefault();

            Console.WriteLine(methodSyntax);
        }
    }
}
