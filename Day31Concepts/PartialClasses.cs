using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.PartialClasses
{
    public partial class Hello
    {
        public void HelloWorld() => Console.WriteLine("Hello World");
    }

    public partial class Hello
    {
        public void HelloUniverse() => Console.WriteLine("Hello Universe");
    }
}
