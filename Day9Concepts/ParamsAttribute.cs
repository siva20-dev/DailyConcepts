using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.OptionalParameters
{
    class ParamsAttribute
    {
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers )
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }
            Console.WriteLine("Sum= " + result);
        }
    }
}
