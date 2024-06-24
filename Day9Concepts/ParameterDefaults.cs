using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.OptionalParameters
{
    class ParameterDefaults
    {
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
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

        public static void Test(int number1, int number2 = 10, int number3 = 10)
        {
            Console.WriteLine("number1 = " + number1);
            Console.WriteLine("number2 = " + number2);
            Console.WriteLine("number3 = " + number3);
        }
    }
}
