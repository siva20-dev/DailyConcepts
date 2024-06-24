using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClass
{
    public class ListClassExamples
    {
        public void ListClassExamples1()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void InsertingAnObject()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer customer3 = new Customer()
            {
                Id = 1,
                Name = "John",
                Salary = 3500
            };
            customers.Insert(0, customer3);

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0},Id={1},Salary = {2}", customer.Name, customer.Id, customer.Salary);
            }

            Console.WriteLine(customers.IndexOf(customer3));

            Console.WriteLine(customers.IndexOf(customer3,1,2));

        }
    }
}
