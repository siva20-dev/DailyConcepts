using System;
using whyproperties = Day7Concepts.WhyProperties;
using properties = Day7Concepts.Properties;
using Day7Concepts.StructureConcepts;

namespace Day7Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetterAndSetterMethods();

            Properties();

            Structures();
        }

        static void GetterAndSetterMethods()
        {
            whyproperties.Student C1 = new whyproperties.Student();
            C1.SetId(101);
            C1.SetName("Mark");

            Console.WriteLine("Student Id = {0}", C1.GetId());
            Console.WriteLine("Student Name = {0}", C1.GetName());
            Console.WriteLine("Student PassMark = {0}", C1.GetPassMark());
        }

        static void Properties()
        {
            properties.Student C2 = new properties.Student();
            C2.Id = 101;
            C2.Name = "Mark";

            Console.WriteLine("Student Id = {0}", C2.Id);
            Console.WriteLine("Student Name = {0}", C2.Name);
            Console.WriteLine("Student PassMark = {0}", C2.PassMark);
        }

        static void Structures()
        {
            Customer C1 = new Customer(101, "Mark");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.Id = 102;
            C2.Name = "John";
            C2.PrintDetails();

            Customer C3 = new Customer  
            {
                Id = 103,
                Name = "Rob"
            };
            C3.PrintDetails();
        }
    }
}
