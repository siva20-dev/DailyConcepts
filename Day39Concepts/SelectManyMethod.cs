using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.ProjectionOperators
{
    public class SelectManyMethod
    {
        public void Example1()
        {
            List<string> names = new List<string>() { "Nithin", "KaushiK" };

            var methodSyntax = names.SelectMany(x => x).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void Example2()
        {
            var employees = new List<EmployeeProgram>()
            {
                new EmployeeProgram() { Id = 1,Name = "Tom", Email = "tom@gmail.com", Programming = new List<string>(){"C#","PHP","Java"} },
                new EmployeeProgram() { Id = 2,Name = "Kim", Email = "Kim@gmail.com", Programming = new List<string>(){"LINQ","C#","MVC"} },
                new EmployeeProgram() { Id = 3,Name = "Harry", Email = "Harry@gmail.com", Programming = new List<string>(){"LINQ","VB","SQL"} },
            };

            var methodSyntax = employees.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in methodSyntax)
            {

                Console.WriteLine("Programming- " + item);
            }
        }

        public void Example3()
        {
            var employees = EmployeeTestData.GetEmployeesTech();

            var methodSyntax = employees.SelectMany(emp => emp.Programming).ToList();

            foreach (var programmingLanguage in methodSyntax)
            {
                Console.WriteLine("Programming- " + programmingLanguage.Technology);
            }

            Console.ReadLine();
        }
    }
}
