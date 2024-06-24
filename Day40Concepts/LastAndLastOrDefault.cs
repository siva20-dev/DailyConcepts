using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperators
{
    public class LastAndLastOrDefault
    {
        public void Example1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Last(number => number < 5);

            Console.WriteLine(methodSyntax);
        }

        public void Example2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.LastOrDefault(number => number > 15);

            Console.WriteLine(methodSyntax);
        }

        public void Example3()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.Last(x => x.UserName == "UserC" && x.Password == "UserC");

            Console.WriteLine(methodSyntax.UserName);
        }

        public void Example4()
        {
            List<User> users = UserData.GetUSers();

            var methodSyntax = users.LastOrDefault(x => x.UserName == "UserC" && x.Password == "UserAdmin");
        }
    }
}
