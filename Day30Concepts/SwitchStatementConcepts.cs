using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.SwitchStatementConcepts
{
    public class SwitchStatement
    {
        public static void SwitchStatementExample1()
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 & 30");
                    break;
            }
        }

        public static void SwitchStatementExample2()
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your Number is {0}",userNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 & 30");
                    break;
            }
        }
    }
}
