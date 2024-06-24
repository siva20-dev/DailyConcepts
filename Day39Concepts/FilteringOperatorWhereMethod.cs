using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.FilteringOperators
{
    public class WhereMethod
    {
        /// <summary>
        /// Example with Integer Data type
        /// </summary>
        public void Example1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax1 = numbers.Where(number => number > 5).ToList();

            foreach (var number in methodSyntax1)
            {
                Console.WriteLine(number);
            }

            var methodSyntax2 = numbers.Where(number => number <= 5 || number > 9).ToList();

            foreach (var number in methodSyntax2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("==========");

            var methodSyntax3 = numbers.Where(number => number > 5 && number < 9).ToList();

            foreach (var number in methodSyntax3)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Example with String Data type
        /// </summary>
        public void Example2()
        {
            var names = new List<string>() { "Tom", "Harry", "Virat","Adam", "Sachin", "Ponting","Butler","Mitchell","Allen","Alexander" };

            var methodSyntax = names.Where(name => name.Length == 3 || name.Length > 5).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Example with Complex Data Type
        /// </summary>
        public void Example3()
        {
            var employees = EmployeeTestData.GetEmployeesTech();

            var methodSyntax1 = employees.Where(emp => emp.Programming.Count == 0).ToList();

            foreach (EmployeeTech employee in methodSyntax1)
            {
                Console.WriteLine(employee.Name);
            }

            var methodSyntax2 = employees.Where(emp => emp.Programming.Count >= 2 && emp.Name == "Tom").ToList();

            foreach (EmployeeTech employee in methodSyntax2)
            {
                Console.WriteLine("Employee name ={0} && Id{1}",employee.Name,employee.Id);
            }
        }
    }
}
