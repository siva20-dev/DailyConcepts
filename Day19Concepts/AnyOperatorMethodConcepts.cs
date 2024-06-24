using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts.AnyOperatorMethodConcepts
{
    public class AnyOperatorMethod
    {
        public void AnyOperatorMethodExample1()
        {
            List<int> numbers = new List<int>();

            var isAvailable = numbers.Any();

            Console.WriteLine(isAvailable);
        }

        public void AnyOperatorMethodSyntaxExample()
        {
            Student[] students = StudentTestData.GetStudents();

            var StudentsWithSeventyMarks = students.Any(student => student.Marks > 70);

            Console.WriteLine(StudentsWithSeventyMarks);

            var StudentsWithEightyMarks = students.Any(student => student.Marks > 80);
            Console.WriteLine(StudentsWithEightyMarks);
        }

        public void AnyOperatorMethodExampleUsingQuerySyntax()
        {
            Student[] students = StudentTestData.GetStudents();

            var StudentsWithSeventyMarks = (from student in students
                                            select student).Any(student => student.Marks > 70);

            Console.WriteLine(StudentsWithSeventyMarks);

            var StudentsWithEightyMarks = (from student in students
                                           select student).Any(student => student.Marks > 80);
            Console.WriteLine(StudentsWithEightyMarks);
        }
        public void AnyOperatorMethodSyntaxExample2()
        {
            Student2[] students = StudentTestData.GetStudentsWithSubjects();

            var studentMarks = students.Where(student => student.Subjects.Any(x => x.SubjectMarks > 70)).Select(student => student).ToList();

            foreach (var student in studentMarks)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void AnyOperatorQuerySyntaxExample2()
        {
            Student2[] students = StudentTestData.GetStudentsWithSubjects();

            var studentMarks = (from student in students
                                where student.Subjects.Any(x => x.SubjectMarks > 90)
                                select student).ToList();

            foreach (var student in studentMarks)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
