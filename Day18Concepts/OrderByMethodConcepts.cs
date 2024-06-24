using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts.OrderByMethodConcepts
{
    public class OrderByMethod
    {
        public void OrderByMethodUsingQuerySyntaxExample1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var numbersInAscendingOrder = (from number in numbers
                                           orderby number
                                           select number).ToList();

            foreach (var number in numbersInAscendingOrder)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByMethodUsingMethodSyntaxExample1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var numbersInAscendingOrder = numbers.OrderBy(number => number).ToList();

            foreach (var number in numbersInAscendingOrder)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByMethodUsingQuerySyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInAlphabeticalOrder = (from name in names
                                            orderby name
                                            select name).ToList();

            foreach (var name in namesInAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByMethodUsingMethodSyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInAlphabeticalOrder = names.OrderBy(name => name).ToList();

            foreach (var name in namesInAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByMethodandFilterUsingMethodSyntaxExample()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInAlphabeticalOrder = names.Where(name => name.Length > 4).OrderBy(name => name).ToList();

            foreach (var name in namesInAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByMethodOnObjectsUsingQuerySyntaxExample()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var EmployeesSortedById = (from emp in employee
                                       where emp.Id > 2
                                       orderby emp.Id
                                       select emp).ToList();


            foreach (var emp in EmployeesSortedById)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }

        public void OrderByMethodOnObjectsUsingMethodSyntaxExample()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var EmployeesSortedById = employee.Where (emp => emp.Id <= 2).OrderBy(emp => emp.Id).ToList();


            foreach (var emp in EmployeesSortedById)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }
    }
}
