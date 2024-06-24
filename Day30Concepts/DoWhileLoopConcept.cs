using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.DoWhileLoopConcept
{
    public class DoWhileLoop
    {
        public static void DoWhileLoopExample()
        {
            string userChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter a number");
                int userNumber = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userNumber)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you Want to Continue Yes or No?");

                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Your choice is invalid-Please try again");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }

        public static void DoWhileLoopExampleUsingStrings()
        {
            {
                string input;
                
                do
                {
                    Console.Write("Enter a word (type 'exit' to stop): ");
                    input = Console.ReadLine();
                } while (input != "exit");

                Console.WriteLine("You have exited the loop.");
            }
        }

        public static void CoffeePurchaseExample()
        {
            int totalCoffeeCost = 0;
            string userDecision = string.Empty;
            do
            {
                int userChoice = -1;
                do
                {
                    Console.WriteLine("Please Select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
                    userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            totalCoffeeCost += 1;
                            break;
                        case 2:
                            totalCoffeeCost += 2;
                            break;
                        case 3:
                            totalCoffeeCost += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", userChoice);
                            break;
                    }
                } while (userChoice != 1 && userChoice != 2 && userChoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another Coffee- Yes or No?");
                    userDecision = Console.ReadLine().ToUpper();

                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("Your Choice {0} is invalid.Please try again...", userDecision);
                    }
                } while (userDecision != "YES" && userDecision != "NO");
            }
            while (userDecision.ToUpper() != "NO");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = ${0}", totalCoffeeCost);
        }
    }
}
