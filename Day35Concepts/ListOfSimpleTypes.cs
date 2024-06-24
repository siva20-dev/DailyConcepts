using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClass
{
    public class ListOfSimpleType
    {
        public void ListOfSimpleTypeExample1()
        {
            List<int> numbers = new List<int>() { 2, 6, 3, 4, 5, 1 };
            Console.WriteLine("Before Sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();

            Console.WriteLine("After Sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Descending Order");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void ListOfSimpleTypeExample2()
        {
            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alphabets in Reverse Order");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
