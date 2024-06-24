using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    public class StudentSubject : Student
    {
        public List<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
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
}
