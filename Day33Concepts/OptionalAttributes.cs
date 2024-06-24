using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParameters
{
    public class OptionalAttributes
    {
        public void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
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

        public void DrawSymbol(char symbol = '*', bool isVisible = true, float opacity = 1.0f)
        {
            if (isVisible)
            {
                Console.WriteLine($"Symbol: {symbol}, Opacity: {opacity}");
            }
            else
            {
                Console.WriteLine("Symbol is hidden.");
            }
        }
    }
}
