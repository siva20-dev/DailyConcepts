using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.NullCoalescingOperatorConcept
{
    public class NullCoalescingOperator
    {
        public static void NullCoalescingOperatorExample()
        {
            string name1 = null;
            string name2 = null;
            string name3 = null;
            string name4 = "Name4";

            string finalName = name1 ?? name2?? name3?? name4;

            Console.WriteLine(finalName);
        }
    }
}
