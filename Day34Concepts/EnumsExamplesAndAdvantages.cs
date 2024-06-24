using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.Enums2
{
    public class Enums
    {
        public void EnumExamples()
        {
            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    public enum Gender
    {
        Unknown = 1,
        Male,
        Female
    }
}
