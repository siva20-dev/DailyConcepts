using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.SetOperatorsDistinctMethod
{
    public class DistinctMethod
    {
        public void Example1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 1, 5, 5, 2, 3, 4, 4, 5, };

            var methodSyntax = numbers.Distinct().ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number); 
            }
        }

        public void Example2()
        {
            List<Students> students = StudentTestData.GetStudentsWithIds();

            var methodSyntax = students.Select(student => student.Name).Distinct().ToList();

            foreach (var Names in methodSyntax)
            {
                Console.WriteLine($"Student:{Names}");
            }
        }

        public void IEquatableMethodExample()
        {
            List<Students> students = StudentTestData.GetStudentsWithIds();

            var methodSyntax = students.Distinct().ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }

        public void IEqualityComparerExample()
        {
            List<Students> students = StudentTestData.GetStudentsWithIds();

            var methodSyntax = students.Distinct(new StudentComparer()).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
