using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts.ContainsMethodConcepts
{
    public class ContainsMethod
    {
        public void ContainsMethodExample1()
        {
            List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John" };

            var isExist = students.AsEnumerable().Contains("Kim");

            Console.WriteLine(isExist);

            var isPresent = (from student in students
                             select student).Contains("Jacob");

            Console.WriteLine(isPresent);
        }

        public void ContainsMethodExample2()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Marks =85 ,Name = "Kim"},
                new Student() { Marks = 72, Name = "John" },

            };

            var comparer = new StudentComparer();

            var isExist = students.AsEnumerable().Contains(new Student() { Marks = 85, Name = "Kim" }, comparer);

            Console.WriteLine(isExist);

            var isPresent = (from student in students
                            select student).Contains(new Student() { Marks = 85, Name = "Kim" }, comparer);

            Console.WriteLine(isPresent);
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Marks == y.Marks && x.Name == y.Name;
        }

        public int GetHashCode(Student obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int marksHashCode = obj.Marks.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return marksHashCode + nameHashCode;
        }
    }
}

