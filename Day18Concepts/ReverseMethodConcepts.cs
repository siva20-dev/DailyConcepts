using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.ReverseMethodConcepts
{
    public class ReverseMethod
    {
        public void ReverseMethodConceptsMethodSyntaxExample1()
        {
            int[] rollNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var reversingRollNumbers = rollNumbers.Reverse().ToList();

            foreach (int rollNumber in reversingRollNumbers)
            {
                Console.WriteLine(rollNumber);
            }
        }

        public void ReverseMethodConceptsQuerySyntaxExample1()
        {
            int[] rollNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var reversingRollNumbers = (from rollNumber in rollNumbers
                                       select rollNumber).Reverse().ToList();

            foreach (int rollNumber in reversingRollNumbers)
            {
                Console.WriteLine(rollNumber);
            }
        }

        public void ReverseMethodConceptsMethodSyntaxExample2()
        {
            List<string> names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            //var reversingRollNames = names.AsEnumerable().Reverse().ToList();

            //or

            var reversingRollNames = names.AsQueryable().Reverse().ToList();

            foreach (string name in reversingRollNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
