using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.MethodsConcept
{
    public class Methods
    {
        public void InstanceMethodExample()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }

        public static void StaticMethodExample()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }

        public static void MethodWithParameterExample(int Target)
        {
            int start = 0;

            while (start <= Target)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }

        public static int MethodWithReturnExample(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
