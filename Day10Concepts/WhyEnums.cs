using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.WhyEnums
{
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female ";
                default:
                    return "Invalid Data Detected";
            }
        }

    }
}
