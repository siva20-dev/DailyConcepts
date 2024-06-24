using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.ReadingAndWritingAConsoleConcepts
{
    public class ReadingAndWritingAConsole
    {
        public static void StoringValuesInVariablesAndDisplayningUsingWriteLine()
        {
            int number = 12345;

            string name = "Savar technologies";

            Console.WriteLine(number);
            Console.WriteLine(name);
        }

        public static void PassingValuesInsideWriteLine()
        {
            Console.WriteLine(12345);
            Console.WriteLine("Savar technologies");
        }

        public static void WriteAndWriteLineExample()
        {
            Console.WriteLine("Savar");
            Console.WriteLine("technologies");

            Console.WriteLine("------------");

            Console.Write("Savar");
            Console.WriteLine("Technologies");

            Console.Write("Hello");
        }

        public static void Concatenation()
        {
            Console.WriteLine("Please Enter First name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("First name is " + firstName + " Second name is " + lastName);
        }

        public static void PlaceHolderSyntax()
        {
            Console.WriteLine("Please Enter First name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("First name is {0} and Last Name is {1}",firstName,lastName);
        }

        public static void Interpolation()
        {
            Console.WriteLine("Please Enter First name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last name");
            string lastName = Console.ReadLine();

            Console.WriteLine($"First name is {firstName} and Last Name is {lastName}");
        }

        public static void ReadExample()
        {
            Console.WriteLine("Please Enter a Character");
            int number = Console.Read();

            Console.WriteLine(number);
        }

        public static void VariablesExample()
        {
            int number = 1234;
            Console.WriteLine(number);

            string name = "Savar";
            Console.WriteLine(name);
        }

        public static void BuiltInDataTypes()
        {
            int number;
            string name;
            long countryPopulationn;

            int maxValueOfInt = 2147483647;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine($"Size of float is {sizeof(float)}");
            Console.WriteLine($"Max value of float is {int.MaxValue}");
            Console.WriteLine($"Min value of float is {int.MinValue}\n");

            Console.WriteLine($"Size of double is {sizeof(double)}");
            Console.WriteLine($"Max value of double is {int.MaxValue}");
            Console.WriteLine($"Min value of double is {int.MinValue}\n");

            Console.WriteLine($"Size of decimal is {sizeof(decimal)}");
            Console.WriteLine($"Max value of decimal is {int.MaxValue}");
            Console.WriteLine($"Min value of decimal is {int.MinValue} \n");
        }

        public static void BuiltInDataTypesExample2()
        {
            float number1 = 23.45f;
            double number2 = 23.45;
            decimal number3 = 23.35m;

            bool isValid = true;
            bool isValid2 = false;

            char letter = 'A';

            string name = "Siva";

            string password = "Welome23$5";
        }
    }
}
