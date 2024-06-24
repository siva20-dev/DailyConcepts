using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts.ListClassConcepts
{
    public class ListClassConceptsExample
    {
        public static void ListCollectionClassExamples()
        {
            Customer customer3 = new Customer()
            {
                Id = 104,
                Name = "Rob",
                Salary = 7000
            };

            List<Customer> customers = CustomerTestData.GetCustomers();

            foreach (Customer c in customers)
            {
                Console.WriteLine("ID={0}, Name = {1},Salary= {2}", c.Id, c.Name, c.Salary);
            }
        }

        public static void ListAddFunctionExamples()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer C = customers[0];
            Customer d = customers[1];
            Console.WriteLine("ID={0}, Name = {1},Salary= {2}", C.Id, C.Name, C.Salary);
            Console.WriteLine("ID={0}, Name = {1},Salary= {2}", d.Id, d.Name, d.Salary);

            Customer customer3 = new Customer()
            {
                Id = 104,
                Name = "Rob",
                Salary = 7000
            };

            customers.Insert(0, customer3); 

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.Id);
            }

            customers.Insert(4, customer3);

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.Id);
            }
        }

        public static void ListGetItemsExamples()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer customer3 = new Customer()
            {
                Id = 104,
                Name = "Rob",
                Salary = 7000
            };
            Console.WriteLine(customers.IndexOf(customer3)); 

            Console.WriteLine(customers.IndexOf(customer3, 1, 2)); 
        }
    }
}
