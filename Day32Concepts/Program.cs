using System;
using inheritance = Day32Concepts.InheritanceConcepts;
using methodhiding = Day32Concepts.MethodHidingConcepts;
using polymorphism = Day32Concepts.Polyporphism;
using Day32Concepts.MethodOverRidingVSMethodHiding;
using Day32Concepts.MethodOverLoadingConcept;
using whyproperties = Day32Concepts.WhyProperties;
using properties = Day32Concepts.Properties;
using Day32Concepts.Structs;

namespace Day32Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InheritanceExamples();

            MethodHidingConcepts();

            PolymorphismConcepts();

            MethodOverRidingVSMethodHiding();

            WhyPropertiesExamples();

            PropertiesExamples();

            StructsConcepts();

        }

        static void InheritanceExamples()
        {
            inheritance.FullTimeEmployee FTE = new inheritance.FullTimeEmployee();
            FTE.firstName = "Pragim";
            FTE.lastName = "Technologies";
            FTE.PrintFullName();

            inheritance.PartTimeEmployee PTE = new inheritance.PartTimeEmployee();
            PTE.firstName = FTE.firstName;
            PTE.lastName = FTE.lastName;
            PTE.PrintFullName();

            ChildClass childClass = new ChildClass();

            inheritance.FullTimeEmployee fullTimeEmployee = new inheritance.FullTimeEmployee();
            fullTimeEmployee.firstName = "Full Time";
            fullTimeEmployee.lastName = "Employee";
            fullTimeEmployee.PrintFullName();
        }

        static void MethodHidingConcepts()
        {
            methodhiding.Employee partTimeEmployee = new methodhiding.PartTimeEmployee();
            //methodhiding.PartTimeEmployee partTimeEmployee = new methodhiding.PartTimeEmployee();
            partTimeEmployee.firstName = "PartTime";
            partTimeEmployee.lastName = "Employee";
            partTimeEmployee.PrintFullName();
            ((methodhiding.Employee)partTimeEmployee).PrintFullName();
        }

        static void PolymorphismConcepts()
        {
            polymorphism.Employee[] employees = new polymorphism.Employee[4];

            employees[0] = new polymorphism.Employee();
            employees[1] = new polymorphism.FullTimeEmployee();
            employees[2] = new polymorphism.PartTimeEmployee();
            employees[3] = new polymorphism.TemporaryEmployee();

            foreach (var employee in employees)
            {
                employee.PrintFullName();
            }
        }

        static void MethodOverRidingVSMethodHiding()
        {
            BaseClass baseClass = new ChildClass();
            baseClass.Print();

            Baseclass1 baseClass1 = new Derivedclass1();
            baseClass1.Print();

            Derivedclass1 derivedClass1 = new Derivedclass1();
            derivedClass1.Print();
        }

        static void WhyPropertiesExamples()
        {
            whyproperties.Student C1 = new whyproperties.Student();
            C1.SetId(101);
            C1.SetName("Mark");

            Console.WriteLine("Student Id = {0}", C1.GetId());
            Console.WriteLine("Student Name = {0}", C1.GetName());
            Console.WriteLine("Student PassMark = {0}", C1.GetPassMark());
        }

        static void PropertiesExamples()
        {
            properties.Student C2 = new properties.Student();
            C2.Id = 101;
            C2.Name = "Mark";

            Console.WriteLine("Student Id = {0}", C2.Id);
            Console.WriteLine("Student Name = {0}", C2.Name);
            Console.WriteLine("Student PassMark = {0}", C2.PassMark);
        }

        static void StructsConcepts()
        {
            Customer customer1 = new Customer(101, "Mark");
            customer1.PrintDetails();

            Customer customer2 = new Customer();
            customer2.Id = 102;
            customer2.Name = "Rob";
            customer2.PrintDetails();

            Customer customer3 = new Customer
            {
                Id = 103,
                Name = "Siva"
            };
            customer3.PrintDetails();
        }
    }
}
