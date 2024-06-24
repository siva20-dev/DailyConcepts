using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts.UnionMethodConcepts
{
    public class UnionMethod
    {
        public void MethodSyntaxExample1()
        {
            List<string> names1 = new List<string>() { "A", "B", "C", "D" };
            List<string> names2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = names1.Union(names2).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void MixedSyntaxExample1()
        {
            List<string> names1 = new List<string>() { "A", "B", "C", "D" };
            List<string> names2 = new List<string>() { "C", "D", "E", "F" };

            var mixedSyntax = (from name in names1
                               select name).Union(names2).ToList();

            foreach (var name in mixedSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void MethodSyntaxUsingAnonymousMethod()
        {
            List<Students> students1 = StudentTestData.GetStudents5();

            List<Students> students2 = StudentTestData.GetStudents6();

            var methodSyntax = students1.Select(s => new { s.Id, s.Name }).Union(students2.Select(s => new { s.Id, s.Name })).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }

        public void MethodSyntaxUsingIEqualityComparerMethod()
        {
            List<Students> students1 = StudentTestData.GetStudents5();

            List<Students> students2 = StudentTestData.GetStudents6();

            var methodSyntax = students1.Union(students2, new StudentComparer()).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }
    }

    public class StudentComparer : IEqualityComparer<Students>
    {
        public bool Equals(Students x, Students y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Students obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode + nameHashCode;
        }
    }
}

