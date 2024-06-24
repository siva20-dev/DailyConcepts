using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.StringAndStringBuilderConcepts
{
    public class StringAndStringBuilder
    {
        public static void StringAndStringBuilderExamples()
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorials";
            userString += " for";
            userString += " Beginners";

            Console.WriteLine(userString);

            StringBuilder userString1 = new StringBuilder("C#");
            userString1.Append(" Video");
            userString1.Append(" Tutorial");
            userString1.Append(" for");
            userString1.Append(" Begineers");

            Console.WriteLine(userString1);
        }
    }

    

}
