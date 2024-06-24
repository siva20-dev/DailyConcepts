using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.ProjectionOperators
{
    public class SelectMethod
    {
        public void MethodSyntaxExample1()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

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

        public void BindingDataToAnotherClass()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

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

        public void BindingDataToAnonymousClass()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

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
            List<Employee> employees = EmployeeTestData.GetEmployees();

            var employeeIndexAndName = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            foreach (var item in employeeIndexAndName)
            {
                Console.WriteLine($"Id = {item.Index}, Name = {item.FullName}");
            }
        }
    }
}
