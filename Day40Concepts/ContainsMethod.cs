using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperators
{
    public class ContainsMethod
    {
        public void Example1()
        {
            List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John" };

            var methodSyntax = students.AsEnumerable().Contains("Kim");

            Console.WriteLine(methodSyntax);
        }

        public void Example2()
        {
            List<Students> students = StudentTestData.GetStudentsWithIds();
            
            var comparer = new StudentComparer();

            var isExist = students.AsEnumerable().Contains(new Students() { Id = 2, Name = "Kim" }, comparer);

            Console.WriteLine(isExist);
        }
    }
}

