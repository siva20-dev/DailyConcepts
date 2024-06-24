using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleWritingAndReading();

            //Console.WriteLine();

            VariablesAndBuiltinDataTypes();
            VariablesAndBuiltinDataTypes();
        }

        static void ConsoleWritingAndReading() 
        {
            Console.WriteLine("Please Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last Name");
            string lastName = Console.ReadLine();

            //Concatenation
            Console.WriteLine("Entered first name is " + firstName + " and Last name is " + lastName);

            //PlaceHolder Syntax
            Console.WriteLine("Entered first name is {0} and Last name is {1}", firstName, lastName);

            //String Interpolation
            Console.WriteLine($"Entered First name is {firstName} and Last name is {lastName}");
        }

        static void VariablesAndBuiltinDataTypes()
        { 
            //integer,string,long
           
            int number = 6;
            string name = "Siva";
            long countryPopulation = 999999999999;

            Console.WriteLine("Integer " + number);
            Console.WriteLine("String " + name);
            Console.WriteLine("Country Population " + countryPopulation);

            Console.WriteLine("Minimum Integer Value "+int.MinValue);
            Console.WriteLine("Maximum Integer Value "+int.MaxValue);

            Console.WriteLine();

            //float,double,Decimal
           
            float number1 = 23.45f;

            Double number2 = 23.45;

            Decimal number3 = 23.45m;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine();

            Console.WriteLine($"Size of float is {sizeof(float)}");
            Console.WriteLine($"Max value of float is {int.MaxValue}");
            Console.WriteLine($"Min value of float is {int.MinValue}\n");

            Console.WriteLine($"Size of double is {sizeof(double)}");
            Console.WriteLine($"Max value of double is {double.MaxValue}");
            Console.WriteLine($"Min value of double is {double.MinValue}\n");

            Console.WriteLine($"Size of decimal is {sizeof(decimal)}");
            Console.WriteLine($"Max value of decimal is {decimal.MaxValue}");
            Console.WriteLine($"Min value of decimal is {decimal.MinValue} \n");

            //bool,string,Character
           
            bool invalid = false;

            string password = "password123";

            Char letter = 'A';

            Console.WriteLine(invalid);
            Console.WriteLine(password);
            Console.WriteLine(letter);
        }
    }
}
