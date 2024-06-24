using System;

namespace Day4Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileLoop();
            DoWhileLoop();
            CoffeePurchaseExample();
            ForLoop();
            ForEachLoop();
            BreakWithForLoop();
            ContinueWithForLoop();

            Program evenNumber = new Program();
            evenNumber.EvenNumbers();

            EvenNumbersPassingParameters(30);

            Program P = new Program();
            int Sum = P.Add(10, 20);
            Console.WriteLine("Sum = {0}", Sum);

            int number1 = 0;
            ValueParameter(number1);
            Console.WriteLine(number1);

            int number2 = 0;
            ReferenceParameter(ref number2);
            Console.WriteLine(number2);

            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            ParamsMethod();

            int[] numbers1 = { 5, 8, 3, 4, 5, };

            ParamsMethod(numbers1);
            ParamsMethod(1, 2, 3, 4, 5);
        }

        /// <summary>
        /// While loop example-Asks user for a target number and prints all even numbers up to it.
        /// </summary>
        static void WhileLoop()
        {
            Console.WriteLine("Please Enter your Number");
            int userNumber = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userNumber)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }

        /// <summary>
        /// Do While Loop Example-Asks user for a target, prints even numbers, and asks to continue.
        /// </summary>
        static void DoWhileLoop()
        {
            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please Enter your Target");
                int userNumber = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userNumber)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you Want to Continue - Yes or No?");

                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, Please say Yes or No");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }

        static void CoffeePurchaseExample()
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

        /// <summary>
        /// For Loop example-Initializes and prints elements of an integer array.
        /// </summary>
        static void ForLoop()
        {
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
        }

        /// <summary>
        /// For Each Loop example-Iterates through an integer array and prints each element.
        /// </summary>
        static void ForEachLoop()
        {
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Break with for loop example-Prints numbers from 1 to 20, breaking the loop when i equals 10.
        /// </summary>
        static void BreakWithForLoop()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);

                if (i == 10)
                    break;
            }
        }

        /// <summary>
        /// Continue with for loop example-Prints even numbers from 0 to 20 using a for loop, skipping odd numbers.
        /// </summary>
        static void ContinueWithForLoop()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;

                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Instance Method example
        /// </summary>
        public void EvenNumbers()
        {
            int number = 0;

            while (number <= 20)
            {
                Console.WriteLine(number);
                number = number + 2;
            }
        }

        /// <summary>
        /// Method with Enabling Passing Parameters example
        /// </summary>
        public static void EvenNumbersPassingParameters(int number2)
        {
            int number1 = 0;

            while (number1 <= number2)
            {
                Console.WriteLine(number1);
                number1 = number1 + 2;
            }
        }

        /// <summary>
        /// Method with return concept
        /// </summary>
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static void ValueParameter(int number)
        {
            number = 101;
        }

        public static void ReferenceParameter(ref int number)
        {
            number = 101;
        }

        /// <summary>
        /// Out Parameter Example
        /// </summary>
        public static void Calculate(int number1, int number2, out int sum, out int product)
        {
            sum = number1 + number2; //To do
            product = number1 * number2;
        }

        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            
            foreach (int number in numbers)
            {  
                Console.WriteLine(number);
            }
        }
    }
}
