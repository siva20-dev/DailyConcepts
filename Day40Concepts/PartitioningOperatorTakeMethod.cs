using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperators
{
    public class TakeMethod
    {
        public void Example1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }

            var methodSyntax2 = numbers.Where(num => num > 3).Take(5).ToList();

            foreach (var number in methodSyntax2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
