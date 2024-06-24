using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.WaysToWriteALINQQuery
{
    public class LINQConcepts
    {
        public void LinqQueryExamples()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 5, 6, 7, 8 };

            var querySyntax = from num in numbers
                              where num > 2
                              select num;

            foreach (var num in querySyntax)
            {
                Console.WriteLine(num);
            }

            var methodSyntax = numbers.Where(num => num < 5);
            
            foreach (var num in methodSyntax)
            {
                Console.WriteLine(num);
            }

            var mixedSyntax = (from num in numbers
                               select num).Max();

                Console.WriteLine("Max Value is " + mixedSyntax);

        }
    }
}
