using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.TakeWhileMethodConcepts
{
    class TakeWhileMethod
    {
        public void MethodSytaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var methodSyntax = numbers.TakeWhile(x=> x < 7).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSytaxExample1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 5, 6, 3, 8, 9, 10 };

            var mixedSyntax = (from num in numbers
                               select num).TakeWhile(x => x < 7).ToList();


            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSytaxExample2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var methodSyntax = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MixedSytaxExample2()
        {
            List<string> names = new List<string>() { "Kim", "John", "Adam", "Tom", "Nithish" };

            var mixedSyntax = (from name in names
                              select name).TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }
}
