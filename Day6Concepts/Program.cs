using System;
using inheritance = Day6Concepts.inheritance;
using methodhiding = Day6Concepts.MethodHiding;
using polymorphism = Day6Concepts.polymorphism;
using Day6Concepts.MethodOverRidingAndHiding;

namespace Day6Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inheritance();
            Inheritance2();

            MethodHiding();

            Polymorphisim();
            MethodOverLoadingVSMethodHiding();
        }

        static void Inheritance()
        {
            inheritance.FullTimeEmployee FTE = new inheritance.FullTimeEmployee();
            FTE.firstName = "Pragim";
            FTE.lastName = "Tech";
            FTE.yearlySalary = 5000000;
            FTE.PrintFullName();

            inheritance.PartTimeEmployee PTE = new inheritance.PartTimeEmployee();
            PTE.firstName = "Part";
            PTE.lastName = "Time";
            PTE.hourlySalary = 50;
            PTE.PrintFullName();
        }

        /// <summary>
        /// Inheritance concept with over loading constructor (calling constructor of your choice)
        /// </summary>
        static void Inheritance2()
        {
            inheritance.ChildClass CC = new inheritance.ChildClass();
        }

        static void MethodHiding()
        {
            methodhiding.FullTimeEmployee FTE1 = new methodhiding.FullTimeEmployee();
            FTE1.firstName = "FullTime";
            FTE1.lastName = "Employee";
            FTE1.yearlySalary = 5000000;
            FTE1.PrintFullName();

            //methodhiding.PartTimeEmployee PTE1 = new methodhiding.PartTimeEmployee(); 
            methodhiding.Employee PTE1 = new methodhiding.PartTimeEmployee(); //Invoking a hidden base class member from derived class using parent class refernce
            PTE1.firstName = "Part time";
            PTE1.lastName = "Employee";
            PTE1.PrintFullName(); 
            //((methodhiding.Employee)PTE1).PrintFullName(); //Invoking a hidden base class member from derived class using cast type to parent type
        }

        static void Polymorphisim()
        {
            polymorphism.Employee[] employee = new polymorphism.Employee[4];

            employee[0] = new polymorphism.Employee();
            employee[1] = new polymorphism.PartTimeEmployee();
            employee[2] = new polymorphism.FullTimeEmployee();
            employee[3] = new polymorphism.TemporaryEmployee();

            foreach (polymorphism.Employee e in employee)
            {
                e.PrintFullName();
            }
        }

        static void MethodOverLoadingVSMethodHiding()
        {
            Baseclass B = new Derivedclass();
            B.Print();

            Baseclass1 B1 = new Derivedclass1();
            B1.Print();

            Derivedclass1 B2 = new Derivedclass1();
            B2.Print();
        }
    }
}
