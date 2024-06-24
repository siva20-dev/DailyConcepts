using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts.QuantifierAllMethodConcepts
{
    public class QuantifierAllMethod
    {
        public void QuantifierAllMethodExampleUsingMethodSyntax()
        {
            Student[] students = StudentTestData.GetStudents();

            var StudentsWithSeventyMarks = students.All(student => student.Marks > 70);

            Console.WriteLine(StudentsWithSeventyMarks);

            var StudentsWithEightyMarks = students.All(student => student.Marks > 80);
            Console.WriteLine(StudentsWithEightyMarks);
        }

        public void QuantifierAllMethodExampleUsingQuerySyntax()
        {
            Student[] students = StudentTestData.GetStudents();

            var StudentsWithSeventyMarks = (from student in students
                                            select student).All(student => student.Marks > 70);

            Console.WriteLine(StudentsWithSeventyMarks);

            var StudentsWithEightyMarks = (from student in students
                                           select student).All(student => student.Marks > 80);
            Console.WriteLine(StudentsWithEightyMarks);
        }

        public void QuantifierAllMethodUsingMethodSyntaxExample2()
        {
            Student2[] students = StudentTestData.GetStudentsWithSubjects();

            var studentMarks = students.Where(student=>student.Subjects.All(x=>x.SubjectMarks > 70 )).Select(student =>student) .ToList();

            foreach (var student in studentMarks)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void QuantifierAllMethodUsingQuerySyntaxExample2()
        {
            Student2[] students = StudentTestData.GetStudentsWithSubjects();

            var studentMarks = (from student in students
                               where student.Subjects.All(x => x.SubjectMarks > 70)
                               select student).ToList();

            foreach (var student in studentMarks)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
