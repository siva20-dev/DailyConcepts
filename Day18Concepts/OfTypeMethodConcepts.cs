using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.OfTypeMethodConcepts
{
    public class OfTypeMethod
    {
        public void OfTypeMethodExampleUsingMethodSyntax()
        {
            var dataSource = new List<object> { "Adam", "Tom", "Harry", "Alexander", 1, 2, 3, 4 };

            var names = dataSource.OfType<string>().ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var numbers = dataSource.OfType<int>().ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var namesWithGreaterThanThreeLetters = dataSource.OfType<string>().Where(name => name.Length > 3).ToList();

            foreach (var name in namesWithGreaterThanThreeLetters)
            {
                Console.WriteLine(name);
            }
        }

        public void OfTypeMethodExampleUsingQuerySyntax()
        {
            var dataSource = new List<object> { "Adam", "Tom", "Harry", "Alexander", 1, 2, 3, 4 };

            var names = (from name in dataSource
                        where name is string
                        select name).ToList();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            var numbers = (from number in dataSource
                           where number is int
                           select number).ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
