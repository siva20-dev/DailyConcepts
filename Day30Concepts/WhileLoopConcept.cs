using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.WhileLoopConcept
{
    public class WhileLoop
    {
        public static void WhileLoopExample()
        {
            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <=  userNumber)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }
    }
}
