using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperators
{
    public class TakeWhileMethod
    {
        public void Example1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10,3,5,6 };

            var methodSyntax = numbers.TakeWhile(num => num < 7).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void Example2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
