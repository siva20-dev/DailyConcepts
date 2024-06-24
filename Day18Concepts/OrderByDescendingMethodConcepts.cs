using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.OrderByDescendingMethodConcepts
{
    public class OrderByDescendingMethod
    {
        public void OrderByDescendingMethodUsingQuerySyntaxExample1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var numbersInDescendingOrder = (from number in numbers
                                           orderby number descending
                                           select number).ToList();

            foreach (var number in numbersInDescendingOrder)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingMethodUsingMethodSyntaxExample1()
        {
            var numbers = new List<int>() { 10, 52, 13, 24, 51, 69, 77, 98, 29, 100 };

            var numbersInDescendingOrder = numbers.OrderByDescending(number => number).ToList();

            foreach (var number in numbersInDescendingOrder)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingMethodUsingQuerySyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInReverseAlphabeticalOrder = (from name in names
                                                  orderby name descending
                                                  select name).ToList();

            foreach (var name in namesInReverseAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByDescendingMethodUsingMethodSyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInReverseAlphabeticalOrder = names.OrderByDescending(name => name).ToList();

            foreach (var name in namesInReverseAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByDescendingMethodandFilterUsingMethodSyntaxExample()
        {
            var names = new List<string>() { "Tom", "Adam", "Collins", "Alexander" };

            var namesInReverseAlphabeticalOrder = names.Where(name => name.Length > 4).OrderByDescending(name => name).ToList();

            foreach (var name in namesInReverseAlphabeticalOrder)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void OrderByDescendingMethodOnObjectsUsingQuerySyntaxExample()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var EmployeesSortedInDescendingOrderById = (from emp in employee
                                       where emp.Id > 2
                                       orderby emp.Id descending
                                       select emp).ToList();


            foreach (var emp in EmployeesSortedInDescendingOrderById)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }

        public void OrderByDescendingMethodOnObjectsUsingMethodSyntaxExample()
        {
            List<Employee> employee = EmployeeTestData.GetEmployees();

            var EmployeesSortedInDescendingOrderById = employee.Where(emp => emp.Id <= 2).OrderByDescending(emp => emp.Id).ToList();


            foreach (var emp in EmployeesSortedInDescendingOrderById)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Email = {emp.Email}");
            }
        }
    }
}
