using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    public class EmployeeTestData
    {
        public static List<Employee> GetEmployees()
        {
            var employee = new List<Employee>()
            {
                new Employee() {
                    Id = 3,
                    Email= "smith@gmail.com",
                    Name = "Smith"
                },

                new Employee() {
                    Id = 2,
                    Email= "thomas@gmail.com",
                    Name = "Thomas"
                },

                new Employee() {
                    Id = 1,
                    Email= "Allen@gmail.com",
                    Name = "Allen"
                },

                new Employee() {
                    Id = 4,
                    Email= "anderson@gmail.com",
                    Name = "Anderson"
                }
            };

            return employee;
        }
    }
}
