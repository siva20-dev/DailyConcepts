using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Day2Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTypeConversion();
            //BoxingAndUnboxing();
            //Console.WriteLine();
            //Array();
            //Comments();
        }

        static void DataTypeConversion()
        {
            // Implicit Conversion
            int number1 = 100;
            long number2 = number1;
            float number3 = number1;

            Console.WriteLine(number1);

            Console.WriteLine("After Conversion");
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            // Explicit Conversion
            float number4 = 123.45f;
            Console.WriteLine(number4);

            int number5 = (int)number4;     // Typecast Operator
            long number6 = (long)number4;  // Typecast Operator

            Console.WriteLine("After Conversion");
            Console.WriteLine(number5);
            Console.WriteLine(number6);

            int number7 = Convert.ToInt32(number4); // Convert Class
            Console.WriteLine(number7);

            Console.WriteLine();

            float number8 = 2372456729109.23f;
            int number9 = (int)number8;
            int number10 = Convert.ToInt32(number8);

            Console.WriteLine(number9);
            Console.WriteLine(number10);
        }

        static void BoxingAndUnboxing()
        {
            // Boxing
            int number1 = 100; // Value type 
            object Obj1 = number1; // Reference Type

            Console.WriteLine("Boxing");
            Console.WriteLine(number1);
            Console.WriteLine(Obj1);

            // Unboxing
            object Obj2 = 200;
            int number2 = (int)Obj2;

            Console.WriteLine("Unboxing");
            Console.WriteLine(Obj2);
            Console.WriteLine(number2);

            // Parse
            string number3 = "1234";
            Console.WriteLine(number3);

            int number4 = int.Parse(number3);
            Console.WriteLine(number4);

            // Try Parse
            Console.WriteLine("Please enter first number");
            int.TryParse(Console.ReadLine(), out int number5);

            Console.WriteLine("Please enter first number");
            int number6 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of both numbers is {number5 + number6}");
        }

        static void Array()
        {
            // Array
            int employeeId1 = 25;
            int employeeId2 = 40;
            int employeeId3 = 60;
            int employeeId4 = 98;
            int employeeId5 = 100;

            // Declaration of Integer Array
            int[] employeeIds = new int[5];

            // Initialization of  Integer Array
            employeeIds[0] = 25;
            employeeIds[1] = 40;
            employeeIds[2] = 60;
            employeeIds[3] = 98;
            employeeIds[4] = 100;

            // Declaration Initialization of an Integer Array
            int[] employeeIds1 = new int[5] { 25, 40, 60, 98, 100 };
            int[] employeeIds2 = new int[] { 25, 40, 60, 98, 100 };
            int[] employeeIds3 = { 25, 40, 60, 98, 100 };

            Console.WriteLine("Employee Id is " + employeeIds[0]);

            // Declaration of String Array
            string[] employeeNames = new string[5];

            // Initialization of  String Array
            employeeNames[0] = "Rohit";
            employeeNames[1] = "Teja";
            employeeNames[2] = "Manohar";
            employeeNames[3] = "Kiran";
            employeeNames[4] = "Siva";

            // Declaration Initialization of an String Array
            string[] employeeNames1 = new string[5] { "Rohit", "Teja", "Manohar", "Kiran", "Siva" };
            string[] employeeNames2 = new string[] { "Rohit", "Teja", "Manohar", "Kiran", "Siva" };
            string[] employeeNames3 = { "Rohit", "Teja", "Manohar", "Kiran", "Siva" };

            Console.WriteLine("Employee Name is " + employeeNames[0]);
        }

        static void Comments()
        {

            //Single line comment
            //Console.WriteLine("Test1");

            //Multi line Comment
            /*console.writeline("test2");
            console.writeline("test3");
            console.writeline("test4");*/

            //Page or XML Document
            TestMethod();

        }
        
        /// <summary>
        /// This is a Test Method for Testing
        /// </summary>
        static void TestMethod()
        { 
        
        }
    }
}
