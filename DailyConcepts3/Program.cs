using System;

namespace DailyConcepts3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssignmentOperator();
            ArithmeticOperator();
            ComparisonOperator();
            ConditionalOperator();
            TernaryOperator();
            IfStatement();
            IfElseIfStatment();
            OrStatementExample1();
            OrStatementExample2();
            AndStatementExample1();
            AndStatementExample2();
            SwitchStatementExample();
            CoffeePurchasingExample();
            NullCoalescingOperator();
        }

        static void AssignmentOperator()
        {
            int number1 = 10;
            bool isValue = true;

            Console.WriteLine(isValue);
        }

        static void ArithmeticOperator()
        {
            int number1 = 10;
            int number2 = 2;

            int result = number1 / number2; // To do 
            int remainder = number1 % number2;

            Console.WriteLine("Result = {0}", result); // Quotient
            Console.WriteLine("Remainder is " + remainder); //Remainder

            int number3 = 10;
            int number4 = 2;

            int addition = number3 + number4;
            int subtraction = number3 - number4;
            int multiplication = number3 * number4;

            Console.WriteLine(addition);   
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
        }

        static void ComparisonOperator()
        {
            int number = 10;
            
            if (number == 10)
            {
            }

            if (number != 10)
            {
            }

            if (number > 10)
            {
            }

            if (number >= 10)
            {
            }

            if (number! < 10)
            {
            }

            if (number <= 10)
            {
            }
        }

        static void ConditionalOperator()
        {
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20) // And Operator
            {
                Console.WriteLine("Hello");
            }

            if (number1 == 10 || number2 == 20) // or Operator
            {
                Console.WriteLine("Hi");
            }
        }

        static void TernaryOperator()
        {
            int number = 10;
            
            bool isNumber10;

            if (number == 10)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("Number = 10 is {0}", isNumber10);

            int number1 = 10;
            
            bool isNumber110 = number1 == 15 ? true : false;

            Console.WriteLine("Number1 == 10 is {0}", isNumber110);
        }

        static void IfStatement()
        {
            Console.WriteLine("Please enter your number");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your Number is One");
            }

            if (userNumber == 2)
            {
                Console.WriteLine("Your Number is Two");
            }

            if (userNumber == 3)
            {
                Console.WriteLine("Your Number is Three");
            }

            if (userNumber != 1 && userNumber != 2 && userNumber != 3)
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }
        }
        static void IfElseIfStatment()
        {
            Console.WriteLine("Please Enter your number");
            int userNUmber = int.Parse(Console.ReadLine());

            if (userNUmber == 1)
            {
                Console.WriteLine("Your Number is One");
            }

            else if (userNUmber == 2)
            {
                Console.WriteLine("Your Number is Two");
            }

            else if (userNUmber == 3)
            {
                Console.WriteLine("Your Number is Three");
            }

            else
            {
                Console.WriteLine("Your Number is not in Between 1 and 3");
            }
        }

        static void OrStatementExample1()
        {
            Console.WriteLine("Please Enter your number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 | userNumber == 20) 
            {
                Console.WriteLine("Your number is 10 or 20");
            }
        }

        /// <summary>
        /// or statement with Double pipe example
        /// </summary>
        static void OrStatementExample2() 
        { 
            Console.WriteLine("Please Enter your number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 || userNumber == 20)  
            {
                Console.WriteLine("Your number is 10 or 20");
            }
        }
        static void AndStatementExample1()
        {
            Console.WriteLine("Please Enter your number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 & userNumber == 20) 
            {
                Console.WriteLine("Your number is 10 or 20");
            }
        }

        static void AndStatementExample2()
        {
            Console.WriteLine("Please Enter your number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 10 && userNumber == 20)
            {
                Console.WriteLine("Your number is 10 or 20");
            }
        }

        static void SwitchStatementExample() 
        {
            Console.WriteLine("Please enter your number");
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
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 or 30");
                    break;
            }

            // Joining Multiple Case Statements

            Console.WriteLine("Please enter your number");
            int userNumber1 = int.Parse(Console.ReadLine());

            switch (userNumber1)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}",userNumber1);
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 or 30");
                    break;
            }
        }

        static void CoffeePurchasingExample() 
        { 
            int totalCoffeeCost = 0;

        Start:
            Console.WriteLine("Please Select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
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
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    goto Start;
            }

        Decide:
            Console.WriteLine("DO you want to buy another coffee- Yes or No?");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper()) 
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid. Please try again", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = ${0}", totalCoffeeCost);
        }

        static void NullCoalescingOperator()
        {
            string name1 = null;
            string name2 = null;
            string name3 = null;
            string name4 = "str4";

            string finalName1 = name1 ?? name2 ?? name3 ?? name4;

            Console.WriteLine(finalName1);

            string name5 = null;
            string name6 = null;
            string name7 = "str3";
            string name8 = "str4";

            string finalName2 = name5 ?? name6 ?? name7 ?? name8;

            Console.WriteLine(finalName2);
        }
    }
}


