using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.FirstAndFirstOrDefaultMethodConcepts
{
    public class FirstAndFirstOrDefaultMethod
    {
        public void MethodSyntaxExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First();

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First(number => number > 5);

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.FirstOrDefault (number => number > 10);

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample4()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.First(x=> x.UserName== "Admin" && x.Password == "Admin");

            Console.WriteLine(methodSyntax.UserName);
        }

        public void MethodSyntaxExampleforFirstOrDefaultMethod()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin1");
        }

        public void MixedSyntaxExample1()
        {
            List<User> users = UserData.GetUSers();

            var mixedSyntax = (from user in users
                              select user).First(x => x.UserName == "Admin" && x.Password == "Admin");

            Console.WriteLine(mixedSyntax.UserName);
        }

        public void MixedSyntaxExampleforFirstOrDefaultMethod()
        {
            List<User> users = UserData.GetUSers();

            var mixedSyntax = (from user in users
                              select user).FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin1");
        }
    }
}
