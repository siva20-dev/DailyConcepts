using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.WhereOperatorsConcepts
{
    public class WhereOperators
    {
        public void WhereOperatorExampleQuerySyntaxExample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numbersGreaterThanFive = (from number in numbers
                                          where number > 5
                                          select number).ToList();

            var numbersLessThanFiveAndGreaterThanNine = (from number in numbers
                                                         where number <= 5 || number > 9
                                                         select number).ToList();

            foreach (var number in numbersLessThanFiveAndGreaterThanNine)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereOperatorExampleMethodSyntaxExample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numbersGreaterThanFive = numbers.Where(number => number > 5).ToList();

            var numbersLessThanFiveAndGreaterThanNine = numbers.Where(number => number <= 5 || number > 9).ToList();

            foreach (var number in numbersLessThanFiveAndGreaterThanNine)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereOperatorExampleQuerySyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Harry", "Adam", "Sachin", "Ponting" };

            var namesWithThreeLetters = names.Where(name => name.Length == 3 || name.Length > 5).ToList();

            foreach (var name in namesWithThreeLetters)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void WhereOperatorExampleMethodSyntaxExample2()
        {
            var names = new List<string>() { "Tom", "Harry", "Adam", "Sachin", "Ponting" };

            var namesWithThreeLetters = from name in names
                                        where name.Length == 3
                                        select name;

            foreach (var name in namesWithThreeLetters)
            {
                Console.WriteLine($"{name}");
            }
        }

        public void WhereOperatorExampleQuerySyntaxExample3()
        {
            var dataSource = new List<EmployeeTech>()
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

            var employeesWithNoTechnology = (from emp in dataSource
                                            where emp.Programming.Count == 0
                                            select emp).ToList();

            foreach (EmployeeTech employee in employeesWithNoTechnology)
            {
                Console.WriteLine(employee.Name);
            }

            var employeesWithTwoTechnologies = (from emp in dataSource
                                             where emp.Programming.Count == 2
                                             && emp.Id < 4
                                             select emp).ToList();

            foreach (EmployeeTech employee in employeesWithTwoTechnologies)
            {
                Console.WriteLine(employee.Name);
            }
        }

        public void WhereOperatorExampleMethodSyntaxExample3()
        {
            var dataSource = new List<EmployeeTech>()
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

            var employeesWithNoTechnology = dataSource.Where(emp => emp.Programming.Count == 0).ToList();

            foreach (EmployeeTech employee in employeesWithNoTechnology)
            {
                Console.WriteLine(employee.Name);
            }

            var employeesWithTwoTechnologies = dataSource.Where(emp => emp.Programming.Count >= 2 && emp.Id > 1).ToList();

            foreach (EmployeeTech employee in employeesWithTwoTechnologies)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
