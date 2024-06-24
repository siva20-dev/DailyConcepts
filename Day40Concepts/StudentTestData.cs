using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts
{
    public class StudentTestData
    {
        public static Student[] GetStudents()
        {
            Student[] students = {new Student { Name = "Kim",Marks = 90},
            new Student { Name = "John",Marks = 80},
            new Student { Name = "Lee",Marks = 75} };

            return students;
        }

        public static StudentSubject[] GetStudentsWithSubjects()
        {
            StudentSubject[] students =
                {new StudentSubject {
                Name = "Kim",Marks = 90,
                    Subjects = new List<Subject>(){
                        new Subject (){SubjectName = "Math",SubjectMarks = 75},
                        new Subject (){SubjectName = "English",SubjectMarks = 80},
                        new Subject (){SubjectName = "Art",SubjectMarks = 86},
                        new Subject (){SubjectName = "History",SubjectMarks = 95}
                    } },

                new StudentSubject {
                Name = "John",Marks = 80,
                    Subjects = new List<Subject>(){
                        new Subject (){SubjectName = "Math",SubjectMarks = 89},
                        new Subject (){SubjectName = "English",SubjectMarks = 91},
                        new Subject (){SubjectName = "Art",SubjectMarks = 90},
                        new Subject (){SubjectName = "History",SubjectMarks = 91}
                    } },

                new StudentSubject {
                Name = "Lee",Marks = 75,
                    Subjects = new List<Subject>(){
                        new Subject (){SubjectName = "Math",SubjectMarks = 75},
                        new Subject (){SubjectName = "English",SubjectMarks = 80},
                        new Subject (){SubjectName = "Art",SubjectMarks = 60},
                        new Subject (){SubjectName = "History",SubjectMarks = 91}
                    }    } };

            return students;
        }

        public static List<Students> GetStudentsWithIds()
        {
            List<Students> students = new List<Students>()
            {
                new Students() {Id = 1,Name = "John"},
                new Students() {Id = 2,Name = "Kim"},
                new Students() {Id = 1,Name = "John"},
                new Students() {Id = 4,Name = "Adam"},
            };

            return students;
        }

        public static List<Students> GetStudentsWithIds2()
        {
            List<Students> students2 = new List<Students>()
            {
                new Students() {Id = 1,Name = "John"},
                new Students() {Id = 2,Name = "Kim"},
                new Students() {Id = 5,Name = "John"},
                new Students() {Id = 6,Name = "Mark"},
            };

            return students2;
        }
    }
}
