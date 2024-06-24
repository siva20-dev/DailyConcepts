using System;
using System.Collections.Generic;
using System.Linq;

namespace Day17Concepts.LINQConcepts
{
    public class LINQConcept
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
        public void QuerySyntaxExample()
        {
            var querySyntax = from obj in numbers
                              where obj > 2
                              select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void MethodSyntaxExample()
        {
            var methodSyntax = numbers.Where(obj => obj > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }

        public void MixedSyntaxExample()
        {
            var mixedSyntax = (from obj in numbers
                              select obj).Max();

           Console.WriteLine("Max value is " + mixedSyntax);
        }
    }
}
