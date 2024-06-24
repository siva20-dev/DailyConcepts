using System;
using System.Collections.Generic;
using System.Linq;

namespace Day17Concepts.ProjectionOperatorSelectMethod
{
    public class SelectMethod
    {
        public void SelectMethodExampleUsingQuerySyntax() //To do
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var employeesData = (from emp in employees
                              select emp).ToList();

            foreach (var item in employeesData)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
        }

        public void SelectMethodExampleUsingQuerySyntaxExample1()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var employeesWithIdEmail = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Email = emp.Email
                               }).ToList();

            foreach (var item in employeesWithIdEmail)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
            }
        }

        public void SelectMethodExampleUsingMethodSyntaxExample1()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var employeesWithIdEmail = employees.Select(emp => new Employee()
            {
                Id = emp.Id,
                Email = emp.Email
            }).ToList();

            foreach (var item in employeesWithIdEmail)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
            }
        }

        public void ConvertingDataFromOneClassToAnotherClassQuerySyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var studentsData = (from emp in employees
                               select new Student()
                               {
                                   StudentId = emp.Id,
                                   StudentEmail = emp.Email,
                                   FullName = emp.Name
                               }).ToList();

            foreach (var item in studentsData)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StudentEmail}");
            }
        }

        public void ConvertingDataFromOneClassToAnotherClassMethodSyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var studentsData = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                StudentEmail = emp.Email,
                FullName = emp.Name
            }).ToList();

            foreach (var item in studentsData)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StudentEmail}");
            }
        }

        public void ConvertingDataFromOneClassToAnonymousClassQuerySyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var customData = (from emp in employees
                               select new
                               {
                                   CustomId = emp.Id,
                                   CustomName = emp.Name,
                                   CustomEmail = emp.Email,
                               }).ToList();

            foreach (var item in customData)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }
        }

        public void ConvertingDataFromOneClassToAnonymousClassMethodSyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var customData = employees.Select(emp => new 
            {
                CustomId = emp.Id,
                CustomEmail = emp.Email,
                CustomName = emp.Name
            }).ToList();

            foreach (var item in customData)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }
        }

        public void SelectingTheDataInTheIndexExample()
        {
            List<Employee> employees = EmployeeTestData.GetEmployeeDetails();

            var employeeIndexAndName = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            foreach (var item in employeeIndexAndName)
            {
                Console.WriteLine($"Id = {item.Index}, Name = {item.FullName}");
            }
        }
    }
}
