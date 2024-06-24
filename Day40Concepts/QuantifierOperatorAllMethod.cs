using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperators
{
    public class AllMethod
    {
        public void Example1()
        {
            Student[] students = StudentTestData.GetStudents();

            var methodSyntax = students.All(student => student.Marks > 70);

            Console.WriteLine(methodSyntax);

            var methodSyntax2 = students.All(student => student.Marks > 80);
            Console.WriteLine(methodSyntax2);
        }

        public void Example2()
        {
            StudentSubject[] students = StudentTestData.GetStudentsWithSubjects();

            var methodSyntax = students.Where(student => student.Subjects.All(x => x.SubjectMarks > 70)).Select(student => student).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
