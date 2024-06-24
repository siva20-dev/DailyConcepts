using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.IfStatementConcepts
{
    public class IfStatement
    {
        public static void IfStatementExample()
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your Number is 1");
            }

            else if (userNumber == 2)
            {
                Console.WriteLine("Your Number is 2");
            }

            else if (userNumber == 3)
            {
                Console.WriteLine("Your Number is 3");
            }
            else
            {
                Console.WriteLine("Your Numner is not between 1 and 3");
            }
        }

        public static void IfStatementExample2()
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 || userNumber == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your Number is Neither 10 nor 20");
            }
        }

        public static void IfStatementExample3()
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 | userNumber == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your Number is Neither 10 nor 20");
            }
        }

        public static void IfStatementExampleWithString()
        {
            string secretWord = "apple";

            Console.Write("Guess the secret word: ");
            string userGuess = Console.ReadLine();

            if (userGuess == secretWord)
            {
                Console.WriteLine("Congratulations! You guessed it right!");
            }
            else
            {
                Console.WriteLine("Sorry, that's not the secret word.");
            }
        }
    }
}
