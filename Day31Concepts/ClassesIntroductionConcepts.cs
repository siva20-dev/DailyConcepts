using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.ClassesIntroductionConcepts
{
    public class Customer
    {
        public string _firstName;
        public string _lastName;
        
        public Customer()
            :this("No first Name provided ","No last Name provided")
        { 
        }
        public Customer(string firstName, string lastName) 
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullname()
        {
            Console.WriteLine("Full name = {0}", this._firstName + "" + this._lastName);
        }
    }
}
