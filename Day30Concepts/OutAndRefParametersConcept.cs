using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.OutAndRefParametersConcept
{
    public class OutAndRefParameters
    {
        public static void ReferenceParameterExample(ref int number1)
        {
            number1 = number1 + 10;
        }

        public static void OutParameterExample(out int number1)
        {
            number1 = 0;
            number1 = number1 + 10;
        }
    }
}
