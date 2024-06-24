using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParameters
{
    public class ParameterDefaults
    {
        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(result);
        }

        public void Test(int number1, int number2=10, int number3=20)
        {
            Console.WriteLine("Number1 " + number1);
            Console.WriteLine("Number2 " + number2);
            Console.WriteLine("Number3 " + number3);
        }

        public void RecordEvent(string description, bool isImportant = false, int eventId = 0)
        {
            string importance = isImportant ? "IMPORTANT: " : "";
            Console.WriteLine($"Event: {importance}{description}, Event ID: {eventId}");
        }
    }
}
