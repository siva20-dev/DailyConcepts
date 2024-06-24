using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.MethodOverRidingAndHiding
{
    #region Method overriding vs Method hiding Example
    public class Baseclass
    {
        public virtual void Print()
        {
            Console.WriteLine(" I am a Basecalss Print Method");
        }
    }

    public class Derivedclass : Baseclass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived class Print Method");
        }
    }

    public class Baseclass1
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Basecalss Print Method");
        }
    }

    public class Derivedclass1 : Baseclass1
    {
        public new void Print()
        {
            Console.WriteLine("I am a Derived class Print Method");
        }
    }
    #endregion
}
