using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts
{
    public class UnionMethod
    {
        public void Example1()
        {
            List<string> alphabets1 = new List<string>() { "A", "B", "C", "D" };
            List<string> alphabets2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = alphabets1.Union(alphabets2).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void AnonymousMethodExample()
        {
            List<Students> students1 = StudentTestData.GetStudentsWithIds();

            List<Students> students2 = StudentTestData.GetStudentsWithIds2();

            var methodSyntax = students1.Select(student => new { student.Id, student.Name }).Union(students2.Select(student => new { student.Id, student.Name })).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }

        public void IEqualityComparerMethodExample()
        {
            List<Students> students1 = StudentTestData.GetStudentsWithIds();

            List<Students> students2 = StudentTestData.GetStudentsWithIds2();

            var methodSyntax = students1.Union(students2, new StudentComparer()).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
