using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Day9Concepts.OptionalParameter
{
    class OptionalAttributes
    {
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }
            Console.WriteLine("Total= " + result.ToString());
        }
    }
}
