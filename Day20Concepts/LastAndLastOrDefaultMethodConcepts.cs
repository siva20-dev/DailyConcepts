using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts.LastAndLastOrDefaultMethodConcepts
{
    public class LastAndLastOrDefaultMethod
    {
        public void MethodSyntaxExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Last();

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Last(number => number < 5);

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.LastOrDefault(number => number > 15);

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxExample4()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.Last();

            Console.WriteLine(methodSyntax.UserName);
        }

        public void MethodSyntaxExample5()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.Last(x => x.UserName == "UserC" && x.Password == "UserC");

            Console.WriteLine(methodSyntax.UserName);
        }

        public void MethodSyntaxExampleforLastOrDefaultMethod()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.LastOrDefault(x => x.UserName == "UserC" && x.Password == "UserAdmin");
        }

        public void MixedSyntaxExample1()
        {
            List<User> users = UserData.GetUSers();

            var mixedSyntax = (from user in users
                               select user).Last(x => x.UserName == "UserC" && x.Password == "UserC");

            Console.WriteLine(mixedSyntax.UserName);
        }

        public void MixedSyntaxExampleforLastOrDefaultMethod()
        {
            List<User> users = UserData.GetUSers();

            var mixedSyntax = (from user in users
                               select user).LastOrDefault(x => x.UserName == "Admin" && x.Password == "Admin1");
        }
    }
}
