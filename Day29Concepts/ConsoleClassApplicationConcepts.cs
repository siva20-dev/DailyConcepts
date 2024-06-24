using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.ConsoleClassApplicationConcepts
{
    public class ConsoleClassApplication
    {
        public static void Example1()
        {
            Console.WriteLine("Please Enter a Text");

            string userText = Console.ReadLine();

            Console.WriteLine("User Entered " + userText);
        }

        public static void GetEmployee()
        {
            Console.WriteLine("Employee Details");
        }

        public static void GetDeparment()
        {
            Console.WriteLine("Employee Department");
        }
    }
}
