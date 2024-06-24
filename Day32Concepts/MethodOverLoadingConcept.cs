using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodOverLoadingConcept
{
    public class MethodOverLoading
    {
        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public static void Add(float firstNumber, float secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public static void Add(int firstNumber, float secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber);
        }

        public static void Add(int firstNumber, int secondNumber, out int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
            thirdNumber = firstNumber + secondNumber;
        }

        public static void PrintDetails(string name, decimal salary)
        {
            Console.WriteLine($"{name} && {salary}");
        }

        public static void PrintDetails(string name, char lastName)
        {
            Console.WriteLine($"{name} && {lastName}");
        }

        public static void PrintDetails(string city, DateTime presentDate)
        {
            Console.WriteLine($"{city} {presentDate}");
        }

        public static void PrintDetails(string city, bool isInIndia)
        {
            Console.WriteLine($"{city} {isInIndia}");
        }
    }
}
