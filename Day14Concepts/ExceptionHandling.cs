using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.ExceptionHandling
{
    public class ExceptionHandlingConcept
    {
        public static void TryCatchExample()
        {
            int number1;
            int number2;

            Console.WriteLine("Enter Number1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int outPut = number1 / number2;
                Console.WriteLine(outPut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
