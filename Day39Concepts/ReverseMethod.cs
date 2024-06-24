using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.SortingOperators
{
    public class ReverseMethod
    {
        public void Example1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Reverse().ToList();

            foreach (int rollNumber in methodSyntax)
            {
                Console.WriteLine(rollNumber);
            }
        }

        public void Example2()
        {
            List<string> names = new List<string>() { "Tom", "Harry", "Virat", "Adam", "Sachin", "Ponting", "Butler", "Mitchell", "Allen", "Alexander" };

            var methodSyntax = names.AsEnumerable().Reverse().ToList();

            var methodSyntax2 = names.AsQueryable().Reverse().ToList();

            foreach (string name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
