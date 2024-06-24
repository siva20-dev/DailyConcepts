using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.GenericsConcepts
{
    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public static bool AreEqual1<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    public class Calculator1<T>
    {
        public static bool AreEqual2(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
