using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.SortingOperators
{
    public class OrderByDescendingMethod
    {
        public void Example1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var methodSyntax = numbers.OrderByDescending(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }

            var methodSyntax2 = numbers.Where(num => num > 50).OrderByDescending(number => number).ToList();

            foreach (var num in methodSyntax2)
            {
                Console.WriteLine(num);
            }
        }

        public void Example2()
        {
            var names = new List<string>() { "Tom", "Harry", "Virat", "Adam", "Sachin", "Ponting", "Butler", "Mitchell", "Allen", "Alexander" };

            var methodSyntax = names.OrderByDescending(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void Example3()
        {
            var names = new List<string>() { "Tom", "Harry", "Virat", "Adam", "Sachin", "Ponting", "Butler", "Mitchell", "Allen", "Alexander" };

            var methodSyntax = names.Where(name => name.Length > 4).OrderByDescending(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void Example4()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var methodSyntax = employee.Where(emp => emp.Id <= 2).OrderByDescending(emp => emp.Id).ToList();

            foreach (var emp in methodSyntax)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }
    }
}
