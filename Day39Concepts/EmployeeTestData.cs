using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts
{
    public class EmployeeTestData
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 3,Name = "Tom", Email = "tom@gmail.com"},
                new Employee() { Id = 4,Name = "John", Email = "John@gmail.com"},
                new Employee() { Id = 1,Name = "Mark", Email = "Mark@gmail.com"},
                new Employee() { Id = 2,Name = "Kim", Email = "Kim@gmail.com"},
                new Employee() { Id = 5,Name = "Adam", Email = "Adam@gmail.com"}
            };
            return employees;
        }

        public static List<EmployeeTech> GetEmployeesTech()
        {
            var employees = new List<EmployeeTech>()
            {
                new EmployeeTech() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming =
                new List<EmployeeTech>{
                    new EmployeeTech() {Technology = "C#"},
                    new EmployeeTech() {Technology = "PHP"},
                    new EmployeeTech() {Technology = ".Net"},
                    new EmployeeTech() {Technology = "MVC"},
                    new EmployeeTech() {Technology = "SQL"}
                }},

                new EmployeeTech() { Id = 2,Name = "John", Email = "John@gmail.com", Programming =
                new List<EmployeeTech>{
                    new EmployeeTech() {Technology = "C#"},
                    new EmployeeTech() {Technology = "VB"},
                    new EmployeeTech() {Technology = "SQL"}
                }},

                new EmployeeTech() { Id = 3,Name = "Mark", Email = "John@gmail.com", Programming =
                new List<EmployeeTech>{
                    new EmployeeTech() {Technology = "LINQ"},
                    new EmployeeTech() {Technology = "MVC"}
                }},

                new EmployeeTech() { Id = 4,Name = "Kim", Email = "kim@gmail.com", Programming = new List<EmployeeTech>() },
                new EmployeeTech() { Id = 5,Name = "Adam", Email = "adam@gmail.com", Programming = new List<EmployeeTech>() }
            };

            return employees;
        }
    }
}
