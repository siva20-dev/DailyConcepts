using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.EnumsExample
{
    public enum Gender
    {
        Unknown,
        Male,
        Female,
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female ";
                default:
                    return "Invalid Data Detected";
            }
        }
    }
}
