using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts.ComparisionDelegate
{
    public class ComparisionDelegateConcepts
    {
        public static void ComparisionDelegateExamples()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();


            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
            }

            customers.Sort(customerComparer);

            Console.WriteLine("After Sorting");
            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust.Id);
            }

            Console.WriteLine("Before Sorting");
            foreach (Customer cus in customers)
            {
                Console.WriteLine(cus.Id);
            }

            customers.Sort(delegate (Customer c1, Customer c2) { return c1.Id.CompareTo(c2.Id); }); 
            customers.Sort((x,y) => x.Id.CompareTo(y.Id)); 


            Console.WriteLine("After Sorting");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.Id);
            }
        }

        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
