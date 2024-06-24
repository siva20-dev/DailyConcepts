using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.Generics
{
    public class GenericsTopic
    {
        public static bool AreEqual(int number1,int number2)
        {
            return number1 == number2;
        }

        public static void GenericsExample()
        {
            bool equal = AreEqual(0, 0);

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public static bool AreEqual2(object number1, object number2)
        {
            return number1 == number2;
        }
        public static void GenericsExample2()
        {
            bool equal = AreEqual2("Siva", "Siva");

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        #region Method Generic Example
        public static bool AreEqual3<T>(T number1, T number2)
        {
            return number1.Equals(number2);
        }
        public static void GenericsExample3()
        {
            bool equal = AreEqual3<int>(10,10);

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        #endregion
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T number1, T number2)
        {
            return number1.Equals(number2);
        }

        public static bool AreEqual2(T name1, T name2)
        {
            return name1.Equals(name2);
        }
    }
}
