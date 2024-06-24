using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.ConstantReadonly
{
    public class ConstantReadonlyConcept
    {
        readonly int number;
        
        public ConstantReadonlyConcept()
        {
            number = 50;
            Console.WriteLine(number);
        }
        public void ConstantReadonlyExample()
        {
            const int number = 10;
            Console.WriteLine(number);
        }
    }

    public class Static
    {
        static int number2 = 0;

        public Static()
        {
            number2++;
            Console.WriteLine("For First object: "+ number2);
        }
    }
}
