using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParameters
{
    public class OptionalParameterMethodOverLoading
    {
        public void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
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

        public void LogMessage(string message)
        {
            LogMessage(message, false);
        }

        public void LogMessage(string message, bool isImportant)
        {
            LogMessage(message, isImportant, DateTime.Now);
        }

        public void LogMessage(string message, bool isImportant, DateTime timestamp)
        {
            Console.WriteLine($"[{timestamp}] {(isImportant ? "IMPORTANT: " : "")}{message}");
        }
    }
}
