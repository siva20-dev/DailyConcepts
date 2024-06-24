using System;
using Day9Concepts.OptionalParameter;
using Day9Concepts.OptionalParameters;
using System.Text;
using type = Day9Concepts.TypeAndTypeMembers;
using Day9Concepts.StringAndStringBuilderConcepts;

namespace Day9Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterArray();
            methodOverLoading();

            ParameterDefaultsExample();
            NamedParameters();

            OptionalAttributesExample();

            OverRideToString();

            StringAndStringBuilderExample();
        }

        static void ParameterArray()
        {
            ParamsAttribute.AddNumbers(10, 20);
            ParamsAttribute.AddNumbers(10, 20, 30, 40, 50);
            ParamsAttribute.AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }

        static void methodOverLoading()
        {
            MethodOverLoading.AddNumbers(10, 20);
            MethodOverLoading.AddNumbers(10, 20, new int[] { 30, 40 });
        }

        static void ParameterDefaultsExample()
        {
            ParameterDefaults.AddNumbers(10, 20);
            ParameterDefaults.AddNumbers(10, 20, new int[] { 30, 40 });
        }

        static void NamedParameters()
        {
            ParameterDefaults.Test(1);
            ParameterDefaults.Test(1, 2);
            ParameterDefaults.Test(1, number3: 2);
        }

        static void OptionalAttributesExample()
        {
            OptionalAttributes.AddNumbers(10, 20);
            OptionalAttributes.AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }


        static void OverRideToString()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";
            
            Console.WriteLine(C1.ToString());
            //or
            Console.WriteLine(Convert.ToString(C1));
        }

        static void StringAndStringBuilderExample()
        {
            StringAndStringBuilder.StringAndStringBuilderExamples();
        }
    }
}
