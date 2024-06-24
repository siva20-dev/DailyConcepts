using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day30Concepts.SwitchStatementContinuedConcepts
{
    public class SwitchStatementContinued
    {
        public static void CoffeePurchaseExample()
        {
            int totalCoffeeCost = 0;

            Start:
            Console.WriteLine("Please select your coffee Size- 1-Small, 2- Medium, 3- Large");
            int userChoice = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Youe choice is invalid , Please try again");
                    goto Start;
            }

            Decision:
            Console.WriteLine("Would you like to Buy another coffee- Yes or No?");
            string userDescision = Console.ReadLine();
            
            switch (userDescision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice is {0} invalid- Please try again",userDescision);
                    goto Decision;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Your Bill Amount is {0}", totalCoffeeCost);
        }
    }
}
