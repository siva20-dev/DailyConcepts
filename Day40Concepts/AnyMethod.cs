using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperators
{
    public class AnyMethod
    {
        public void Example1()
        {
            List<int> numbers = new List<int>();

            var methodSyntax = numbers.Any();

            Console.WriteLine(methodSyntax);
        }

        public void Example2()
        {
            Student[] students = StudentTestData.GetStudents();

            var methodSyntax = students.Any(student => student.Marks > 70);

            Console.WriteLine(methodSyntax);

            var methodSyntax2 = students.Any(student => student.Marks > 80);
            Console.WriteLine(methodSyntax2);
        }

        public void Example3()
        {
            StudentSubject[] students = StudentTestData.GetStudentsWithSubjects();

            var methodSyntax = students.Where(student => student.Subjects.Any(x => x.SubjectMarks > 91)).Select(student => student).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine("Name {0} && Marks {1}",student.Name,student.Marks);
            }
        }
    }
}
