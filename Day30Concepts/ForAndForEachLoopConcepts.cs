using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.ForAndForEachLoopConcepts
{
    public class ForAndForEachLoop
    {
        public static void WhileLoopExample()
        {
            int[] numbers = { 101, 102, 103 };

            int number = 0;

            while (number < numbers.Length)
            {
                Console.WriteLine(numbers[number]);
                number++;
            }
        }

        public static void StringWhileLoopExample()
        {
            string[] names = { "Siva", "Rohit", "Pavan", "Savar" };

            int index = 0;

            while (index < names.Length)
            {
                string name = names[index];
                Console.WriteLine(name);

                if (name == "Siva")
                {
                    break;
                }

                index++;
            }
        }

        public static void ForLoopExample()
        {
            int[] numbers = { 101, 102, 103 };

            for (int number = 0; number < numbers.Length; number++)
            {
                Console.WriteLine(numbers[number]);
            }
        }

        public static void StringForLoopExample()
        {
            string[] names = { "Siva", "Rohit", "Pavan", "Savar" };

            for (int index = 0; index < names.Length; index++)
            {
                string name = names[index];

                if (name == "Siva")
                {
                    Console.WriteLine(name);
                }
            }
        }

        public static void ForEachLoopExample()
        {
            int[] numbers = { 101, 102, 103 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void StringForEachLoopExample()
        {
            string[] names = { "Siva", "Rohit", "Pavan", "Savar" };

            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }
            
        }

        public static void ForLoopWithBreakStatementExample()
        {
            for (int number = 0; number <= 20; number++)
            {
                Console.WriteLine(number);
                if (number == 10)
                    break;
            }
        }

        public static void ForLoopWithContinueStatementExample()
        {
            for (int number = 1; number <= 20; number++)
            {
                if (number % 2 == 1)
                    continue;
                Console.WriteLine(number);
            }
        }
    }
}
