using System;
using System.Collections.Generic;

namespace Day17Concepts
{
    public class EmployeeTestData
    {
        public static List<Employee> GetEmployeeDetails()//To do list
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1,Name = "Tom", Email = "tom@gmail.com"},
                new Employee() { Id = 2,Name = "John", Email = "John@gmail.com"},
                new Employee() { Id = 3,Name = "Mark", Email = "Mark@gmail.com"},
                new Employee() { Id = 4,Name = "Kim", Email = "Kim@gmail.com"},
                new Employee() { Id = 5,Name = "Adam", Email = "Adam@gmail.com"}
            };
            return employees;
        }
    }
}
