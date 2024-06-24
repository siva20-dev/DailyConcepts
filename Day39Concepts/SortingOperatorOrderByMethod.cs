using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.SortingOperators
{
    public class OrderByMethod
    {
        public void Example1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var methodSyntax = numbers.OrderBy(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void Example2()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander","Wright","Sachin","VikramKumar" };

            var methodSyntax = names.OrderBy(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void Example3()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander", "Wright", "Sachin", "VikramKumar" };

            var methodSyntax = names.Where(name => name.Length > 4).OrderBy(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void Example4()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var methodSyntax = employee.Where(emp => emp.Id <= 2).OrderBy(emp => emp.Id).ToList();


            foreach (var emp in methodSyntax)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }
    }
}
