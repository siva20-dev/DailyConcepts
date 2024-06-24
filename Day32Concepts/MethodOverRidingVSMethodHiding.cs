using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodOverRidingVSMethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a Baseclass Print Method");
        }
    }

    public class ChildClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is a DerivedClass Print Method");
        }
    }

    public class Baseclass1
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a Basecalss Print Method");
        }
    }

    public class Derivedclass1 : Baseclass1
    {
        public new void Print()
        {
            Console.WriteLine("This is a Derived class Print Method");
        }
    }
}
