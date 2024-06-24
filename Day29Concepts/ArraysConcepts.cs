  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts.ArraysConcepts
{
    public class Arrays
    {
        public static void IntegerArrayExample()
        {
            int[] employeeIds = new int[5];
            employeeIds[0] = 1;
            employeeIds[1] = 2;
            employeeIds[2] = 3;
            employeeIds[3] = 4;
            employeeIds[4]= 5;

            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[4]);
        }

        public static void IntegerArrayExample2()
        {
            int[] employeedIds1 = new int[5] { 1, 2, 3, 4,5 };
            int[] employeedIds2 = new int [] { 1, 2, 3, 4, 5 };
            int[] employeedIds3 = { 1, 2, 3, 4, 5 };
        }
        
        public static void FloatArrayExample()
        {
            float[] employeedIds1 = new float[5] { 1.25f, 2.25f, 3.25f, 4.25f, 5.25f};
            float[] employeedIds2 = new float[] { 1, 2, 3, 4, 5 };
            float[] employeedIds3 = { 1, 2, 3, 4, 5 };
        }

        public static void BoolArrayExample()
        {
            bool[] bools = new bool[2] { true, false };
            bool[] bools2 = new bool[] { false, true };
            bool[] bools3 = { true, false };
        }

        public static void StringArrayExample()
        {
            string[] employeeNames = new string[3];
            employeeNames[0] = "Siva";
            employeeNames[1] = "Rohit";
            employeeNames[2] = "Arjun";
            
            Console.WriteLine(employeeNames[0]);
        }

        public static void StringArrayExample2()
        {
            string[] employeeNames1 = new string[3] { "Siva", "Rohit", "Arjun" };
            string[] employeeNames2 = new string[] { "Siva", "Rohit", "Arjun" };
            string[] employeeNames3 = { "Siva", "Rohit", "Arjun" };
        }
    }
}
