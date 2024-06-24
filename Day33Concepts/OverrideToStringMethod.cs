using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OverrideToStringMethod
{
    public class OverrideToStringMethod
    {
        public void OverrideToStringMethodExample()
        {
            int number = 10;

            Console.WriteLine(number.ToString());
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
