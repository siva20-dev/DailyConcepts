using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperators
{
    public class FirstAndFirstOrDefaultMethod
    {
        public void Example1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First();

            Console.WriteLine(methodSyntax);
        }

        public void Example2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First(number => number > 5);

            Console.WriteLine(methodSyntax);
        }

        public void Example3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.FirstOrDefault(number => number > 10);

            Console.WriteLine(methodSyntax);
        }

        public void Example4()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.First(x => x.UserName == "Admin" && x.Password == "Admin");

            Console.WriteLine(methodSyntax.UserName);
        }

        public void Example5()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin1");
        }
    }
}
