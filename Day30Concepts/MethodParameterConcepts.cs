using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.MethodParameterConcepts
{
    public class MethodParameter
    {
        public static void ValueParameterExample(int number)
        {
            number = 101;
        }

        public static void ReferenceParameterExample(ref int number)
        {
            number = 101;
        }

        public static void OutParameterExample(int firstNumber,int secondNumber,out int sum,out int product)
        {
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        }

        public static void ParameterArrayExample(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements",numbers.Length);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}



