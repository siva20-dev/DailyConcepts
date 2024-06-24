using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.OperatorConcepts
{
    public class Operators
    {
        public static void AssignmentOperatorExample()
        {
            int number = 10;

            string name = "Siva";
        }

        public static void ArithmeticOperatorExample()
        {
            int number1 = 10;
            int number2 = 2;

            int result = number1 / number2;

            Console.WriteLine("Result = {0}", result);

            int remainder = number1 % number2;
            Console.WriteLine("Remainder = {0}", remainder);
        }

        public static void ComparisonOperatorExample()
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            if (number == 10)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Entered number is not eqalu to 10");
            }
        }

        public static void AndOperatorExample()
        {
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Hello");
            }
        }

        public static void OrOperatorExample()
        {
            int number1 = 10;
            int number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Hello");
            }
        }

        public static void TerinaryOperatorExample()
        {
            int number = 10;

            bool isNumber10 = number == 10 ? true: false;

            Console.WriteLine("Number = 10 is {0}",isNumber10);
        }
    }
}
