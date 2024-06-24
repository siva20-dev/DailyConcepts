using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperators
{
    public class SkipMethod
    {
        public void Example1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var methodSyntax = numbers.Skip(3).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }

            var methodSyntax2 = numbers.Where(number => number > 5).Skip(3).ToList();

            foreach (var number in methodSyntax2)
            {
                Console.WriteLine(number);
            }
        }

        public void Example2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.Skip(2).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
