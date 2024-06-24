using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Concepts.ClassIntroduction
{
   class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
        }

        ~Customer()
        {
            // Clean UP
        }
    }

    class Customer1
    {
        string _firstName;
        string _lastName;

        public Customer1()
            : this("NO First Name provided", "No Last name Provided")
        {

        }

        public Customer1(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
        }

        ~Customer1 ()
        {
            // Clean UP
        }
    }
}
