using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperators
{
    public class SkipWhileMethod
    {
        public void Example1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10,7,4,2 };

            var methodSyntax = numbers.SkipWhile(num => num < 6).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void Example2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.SkipWhile(name => name.Length > 4).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void Example3()
        {
            List<string> names = new List<string>() { "Kim", "John", "St", "Tom", "Nithish" };

            var methodSyntax = names.SkipWhile((value, index) => value.Length > index).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
