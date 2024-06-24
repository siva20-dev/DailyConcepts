using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.StringAndStringBuilder
{
    public class StringAndStringBuilderTopic
    {
        public void StringExample()
        {
            string userString = "C#";
            userString += "Video";
            userString += "Tutorial";
            userString += "for";
            userString += "Beginners";

            Console.WriteLine(userString);
        }

        public void StringBuilderExample()
        {
            StringBuilder userString =new StringBuilder("C#");
            userString.Append("Video");
            userString.Append("Tutorial");
            userString.Append("for");
            userString.Append("Beginners");

            Console.WriteLine(userString.ToString());
        }
    }
}
