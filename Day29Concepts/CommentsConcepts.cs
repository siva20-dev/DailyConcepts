using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.CommentsConcepts
{
    public class Comments
    {
        public static void SingleLineComments()
        {
            Console.WriteLine("Test1");
            Console.WriteLine("Test2");
            //Console.WriteLine("Test3");
            Console.WriteLine("Test4");
            Console.WriteLine("Test5");
        }

        public static void MultiLineComments()
        {
            /*Console.WriteLine("Test1");
            Console.WriteLine("Test2");
            Console.WriteLine("Test3");*/
            Console.WriteLine("Test4");
            Console.WriteLine("Test5");
        }

        /// <summary>
        /// This is Test Method for Testing
        /// </summary>
        public static void PageOrXMLComments()
        {
            Console.WriteLine("Test1");
            Console.WriteLine("Test2");
            Console.WriteLine("Test3");
            Console.WriteLine("Test4");
            Console.WriteLine("Test5");
        }
    }
}
