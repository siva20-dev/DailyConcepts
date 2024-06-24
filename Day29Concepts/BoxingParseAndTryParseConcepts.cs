using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.BoxingParseAndTryParseConcepts
{
    public class BoxingParseAndTryParse
    {
        public static void BoxingExample()
        {
            int number = 100;
            Console.WriteLine(number);

            object obj = number;
            Console.WriteLine(obj);
        }

        public static void UnBoxingExample()
        {
            object obj = 100;
            Console.WriteLine(obj);

            int number = (int)obj;
            Console.WriteLine(number);
        }

        public static void ParseExample()
        {
            string digits = "1234";
            Console.WriteLine(digits);

            int number1 = int.Parse(digits);
            Console.WriteLine(number1);

            long number2 = long.Parse(digits);
            Console.WriteLine(number2);
        }

        public static void ParseExample2()
        {
            Console.WriteLine("Enter First Number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of First numner {firstNumber} and " + 
                $"Second Number {secondNumber} is {firstNumber + secondNumber}");
        }

        public static void TryParseExample1()
        {
            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(),out int firstNumber);

            Console.WriteLine("Enter Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of First numner {firstNumber} and " +
                $"Second Number {secondNumber} is {firstNumber + secondNumber}");
        }
    }
}
