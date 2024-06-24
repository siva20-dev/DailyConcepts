using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.DebugVsReleaseModeConcept
{
    public class DebugVsReleaseModeConcepts
    {
        public static void M1()
        {
            M2();
        }

        public static void M2()
        {
            M3();
        }

        public static void M3()
        {
            throw new Exception("Some Error");
        }

        public static void DebugSymbolUsage()
        {
#if DEBUG       
            Console.WriteLine(DateTime.Now); //This code should only run in development
#endif
            Console.WriteLine("This is Your Application");
        }
    }
}
