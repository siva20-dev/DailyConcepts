using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.FilteringOperators
{
    public class OfTypeMethod
    {
        public void Example1()
        {
            var dataSource = new List<object> { "Adam", "Tom", "Harry", "Alexander", 1, 2, 3, 4,true,false };

            var names = dataSource.OfType<string>().ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var booleanValues = dataSource.OfType<bool>().ToList();

            foreach (var bools in booleanValues)
            {
                Console.WriteLine(bools);
            }

            var numbers = dataSource.OfType<int>().ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var methodSyntax = dataSource.OfType<string>().Where(name => name.Length > 3).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
