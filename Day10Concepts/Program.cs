using System;
using AccessModifeirs=Day10Concepts.AccessModifiers;
using whyEnums=Day10Concepts.WhyEnums;
using enums = Day10Concepts.EnumsExample;
using Day10Concepts.EnumConcepts;

namespace Day10Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessModifiersExample1();

            WhyEnumsExample();

            EnumsConceptExample();

            EnumsConcpets();
        }

        static void AccessModifiersExample1()
        {
            AccessModifeirs.Customer C1 = new AccessModifeirs.Customer();

            Console.WriteLine(C1.ID);
        }

        static void WhyEnumsExample()
        {
            whyEnums.Customer[] customers = new whyEnums.Customer[3];

            customers[0] = new whyEnums.Customer()
            {
                Name = "Mark",
                Gender = 1
            };

            customers[1] = new whyEnums.Customer()
            {
                Name = "Mary",
                Gender = 2
            };

            customers[2] = new whyEnums.Customer()
            {
                Name = "Sam",
                Gender = 0
            };

            foreach (whyEnums.Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, whyEnums.Customer.GetGender(customer.Gender));
            }
        }

        static void EnumsConceptExample()
        {
            enums.Customer[] customers = new enums.Customer[3];

            customers[0] = new enums.Customer()
            {
                Name = "Mark",
                Gender = enums.Gender.Unknown,
            };

            customers[1] = new enums.Customer()
            {
                Name = "Mary",
                Gender = enums.Gender.Male
            };

            customers[2] = new enums.Customer()
            {
                Name = "Sam",
                Gender = enums.Gender.Female
            };

            foreach (enums.Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, enums.Customer.GetGender(customer.Gender));
            }
        }

        static void EnumsConcpets()
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
}
