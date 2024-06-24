using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.DataTypeConversionConcepts
{
    public class DataTypeConversion
    {
        public static void DataTypeConversionUsingTypeCastOPerator()
        {
            float number = 123.45f;
            Console.WriteLine(number);

            Console.WriteLine("After Conversion");
            int number2 = (int) number;
            Console.WriteLine(number2);

            long number3 = (long) number;
            Console.WriteLine(number3);
        }

        public static void DataTypeConversionUsingConvertClassOPerator()
        {
            float number = 123.45f;
            Console.WriteLine(number);

            Console.WriteLine("After Conversion");
            int number2 = Convert.ToInt32(number);
            Console.WriteLine(number2);

            long number3 = Convert.ToInt64(number);
            Console.WriteLine(number3);
        }

        public static void DataTypeConversionExampleUsingLongAndInteger()
        {
            long number = long.MaxValue;
            Console.WriteLine(number);

            int number2 = (int)number;
            Console.WriteLine(number2);

            int number3 = Convert.ToInt32(number);
            Console.WriteLine(number3);
        }
    }
}
