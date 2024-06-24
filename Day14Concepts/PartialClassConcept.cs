using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.PartialClassConcepts
{
    public partial class Hello
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }

    public partial class Hello
    {
        public void HelloUniverse()
        {
            Console.WriteLine("Hello Universe");
        }
    }

    public class PartialClassExample
    {
        public static void PartialClassExamples()
        {
            Hello hello = new Hello();
            hello.HelloWorld();
            hello.HelloUniverse();
        }
    }
}

