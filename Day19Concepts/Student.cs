using System;
using System.Collections.Generic;

namespace Day19Concepts
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

    }

    public class Student2 : Student
    {
        public List<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }

    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
