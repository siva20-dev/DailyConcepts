using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts.DistinctOperatorConcepts
{
    public class DistinctOperatorMethod
    {
        public void MethodSyntaxExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 1, 5, 5, 2, 3, 4, 4, 5, };

            var methodSyntax = numbers.Distinct().ToList();
        }

        public void QuerySyntaxExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 1, 5, 5, 2, 3, 4, 4, 5, };

            var querySyntax = (from num in numbers
                               select num).Distinct().ToList();
        }

        public void MethodSyntaxExample2()
        {
            List<Student> students = GetStudents3();

            var methodSyntax = students.Select(x => x.Name).Distinct().ToList();

            foreach (var Names in methodSyntax)
            {
                Console.WriteLine($"Student:{Names}");
            }
        }

        public void MixedSyntaxExample2()
        {
            List<Student> students = GetStudents3();

            var querySyntax = (from student in students
                               select student.Name).Distinct().ToList();

            foreach (var Names in querySyntax)
            {
                Console.WriteLine($"Student:{Names}");
            }
        }

        public void MethodSyntaxWithIEquatableMethod()
        {
            List<Students> students = GetStudents4();

            var methodSyntax = students.Distinct().ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }

        public void MethodSyntaxWithIEqualityComparer()
        {
            List<Students> students = GetStudents4();

            var methodSyntax = students.Distinct(new StudentComparer()).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id);
            }
        }

        static List<Student> GetStudents3()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Marks = 75,Name = "John"},
                new Student() {Marks = 82,Name = "Kim"},
                new Student() {Marks = 75,Name = "John"},
                new Student() {Marks = 84,Name = "Mark"},
            };

            return students;
        }
        static List<Students> GetStudents4()
        {
            List<Students> students = new List<Students>()
            {
                new Students() {Id = 1,Name = "John"},
                new Students() {Id = 2,Name = "Kim"},
                new Students() {Id = 1,Name = "John"},
                new Students() {Id = 4,Name = "Mark"},
            };

            return students;
        }
    }

    public class Students : IEquatable<Students>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Students other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(other, this))
            {
                return true;
            }
            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode + nameHashCode;
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

            int IdHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return IdHashCode + nameHashCode;
        }
    }
}
