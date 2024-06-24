using System;
using System.Collections.Generic;
using System.Linq;

namespace Day17Concepts.SelectManyMethodConcept
{
    public class SelectManyMethod
    {
        public void SelectManyMethodExample()
        {
            List<string> names = new List<string>() { "Nithin", "KaushiK" };

            var methodResult = names.SelectMany(x=>x).ToList();

            var queryResult = (from rec in names
                              from ch in rec
                              select ch).ToList();
        }

        public void SelectManyMethodExample2()
        {
            var employees = new List<EmployeeProgram>()
            {
                new EmployeeProgram() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming = new List<string>(){"C#","PHP","Java"} },
                new EmployeeProgram() { Id = 2,Name = "Kim", Email = "Kim@gmail.com", Programming = new List<string>(){"LINQ","C#","MVC"} },
                new EmployeeProgram() { Id = 3,Name = "Harry", Email = "Harry@gmail.com", Programming = new List<string>(){"LINQ","VB","SQL"} },
            };

            var programmingLanguages = employees.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in programmingLanguages)
            {

                Console.WriteLine("Programming- " + item);
            }
        }

        public void SelectManyMethodQuerySyntaxExample()
        {
            var employees = new List<EmployeeProgram>()
            {
                new EmployeeProgram() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming = new List<string>(){"C#","PHP","Java"} },
                new EmployeeProgram() { Id = 2,Name = "Kim", Email = "Kim@gmail.com", Programming = new List<string>(){"LINQ","C#","MVC"} },
                new EmployeeProgram() { Id = 3,Name = "Harry", Email = "Harry@gmail.com", Programming = new List<string>(){"LINQ","VB","SQL"} },
            };

            var programmingLanguages = (from emp in employees
                                       from skills in emp.Programming
                                       select skills).ToList();


            foreach (var item in programmingLanguages)
            {

                Console.WriteLine("Programming- " + item);
            }

            Console.ReadLine();
        }

        public void SelectManyMethodExample3()
        {
            var employees = new List<EmployeeTech>()
            {
                new EmployeeTech() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming =
                new List<EmployeeTech>{
                    new EmployeeTech() {Technology = "C#"},
                    new EmployeeTech() {Technology = "PHP"},
                    new EmployeeTech() {Technology = ".Net"}
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
                    new EmployeeTech() {Technology = "MVC"},
                    new EmployeeTech() {Technology = "C#"}
                }},

                new EmployeeTech() { Id = 4,Name = "Kim", Email = "kim@gmail.com", Programming = new List<EmployeeTech>() },
                new EmployeeTech() { Id = 5,Name = "Adam", Email = "adam@gmail.com", Programming = new List<EmployeeTech>() }
            };

            var programmingLanguages = employees.SelectMany(emp => emp.Programming).ToList();

            foreach (var programmingLanguage in programmingLanguages)
            {
                Console.WriteLine("Programming- " + programmingLanguage.Technology);
            }

            Console.ReadLine();
        }

        public void SelectManyMethodExample4()
        {
            var employees = new List<EmployeeTech>()
            {
                new EmployeeTech() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming =
                new List<EmployeeTech>{
                    new EmployeeTech() {Technology = "C#"},
                    new EmployeeTech() {Technology = "PHP"},
                    new EmployeeTech() {Technology = ".Net"}
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
                    new EmployeeTech() {Technology = "MVC"},
                    new EmployeeTech() {Technology = "C#"}
                }},

                new EmployeeTech() { Id = 4,Name = "Kim", Email = "kim@gmail.com", Programming = new List<EmployeeTech>() },
                new EmployeeTech() { Id = 5,Name = "Adam", Email = "adam@gmail.com", Programming = new List<EmployeeTech>() }
            };

            var programmingLanguages = (from emp in employees
                                       from skills in emp.Programming
                                       select skills).ToList();

            foreach (var programmingLanguage in programmingLanguages)
            {
                Console.WriteLine("Programming- " + programmingLanguage.Technology);
            }
        }
    }
}
