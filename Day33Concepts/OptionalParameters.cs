using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParameters
{
    public class ParameterArray
    {
        public void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
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

        public void LogMessage(string message, int severity = 1, params string[] additionalInfo)
        {
            Console.WriteLine($"Message: {message}, Severity: {severity}");
            foreach (var info in additionalInfo)
            {
                Console.WriteLine($"Additional Info: {info}");
            }
        }
    }
}
