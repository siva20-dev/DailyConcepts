using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.OptionalParameters
{
    public class MethodOverLoading
    {
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int [] restOfNumbers)
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
