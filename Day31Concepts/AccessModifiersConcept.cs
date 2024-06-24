using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.AccessModifiersConcept
{
    public class AccessModifiers
    {
        public string name;

        private string lastName;

        protected int id;
    }

    public class Customer : AccessModifiers
    {
        public void PrintId()
        {
            Customer customer = new Customer();
            customer.id = 101;
        }
    }
}
