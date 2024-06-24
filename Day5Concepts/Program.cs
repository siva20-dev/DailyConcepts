using System;
using employee = Day5Concepts.EmployeeManagement.v1;
using student = StudentManagement;
using Day5Concepts.EmployeeManagement.v1.Payroll;
using Day5Concepts.ClassIntroduction;
using Day5Concepts.StaticInstanceMembersConcepts;


namespace Day5Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employeedepartment();

            Payroll();

            StudentDepartment();

            ConstructorWithParameters();

            ParameterLessConstructor();

            OverLoadingConstructor();

            StaticInstanceMembers staticInstanceMembers = new StaticInstanceMembers();
            staticInstanceMembers.StaticMembersExample1();
            staticInstanceMembers.InstanceMembersExample1();
        }

        static void Employeedepartment()
        {
            employee.Department employeeDepartment = new employee.Department();
            employeeDepartment.DisplayDepartmentInfo();
        }

        static void Payroll()
        {
            Payroll payroll = new Payroll();
            payroll.DisplayPayrollInfo();
        }

        static void StudentDepartment()
        {
            student.Department studentDepartment = new student.Department();
            studentDepartment.DisplayDepartmentInfo();
        }

        static void ConstructorWithParameters()
        {
            Day5Concepts.ClassIntroduction.Customer C1 = new("Pragim", "Technologies");
            C1.PrintFullName();
        }
        
        static void ParameterLessConstructor()
        {
            Customer1 C2 = new Customer1();
            C2.PrintFullName();
        }

        static void OverLoadingConstructor()
        {
            Customer1 C2 = new Customer1();
            C2.PrintFullName();

            Customer1 C1 = new Customer1("P", "T");
            C1.PrintFullName();
        }
    }
}
