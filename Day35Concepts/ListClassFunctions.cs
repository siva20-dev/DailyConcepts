using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClass
{
    public class ListClassFunctions
    {
        public void ListClassContainsFunctionExamples()
        {
            Customer customer = new Customer()
            {
                Id = 119,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> customers = CustomerTestData.GetCustomers();
            Customer customer2 = customers[2];

            if (customers.Contains(customer))
            {
                Console.WriteLine("Customer 3 object Exists in the list");
            }
            else
            {
                Console.WriteLine("Customer 3 object does not Exists in the list");
            }

            if (customers.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("Customer Exists in the list");
            }
            else
            {
                Console.WriteLine("Customer does not Exists in the list");
            }
        }

        public void FindingItemsInAList()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer E = customers.Find(cust => cust.Salary > 5000);
            Console.WriteLine("ID={0}, Name = {1},Salary= {2}", E.Id, E.Name, E.Salary);

            Customer D = customers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("ID={0}, Name = {1},Salary= {2}", D.Id, D.Name, D.Salary);

            List<Customer> C = customers.FindAll(cust => cust.Salary > 5000);
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID={0}, Name = {1},Salary= {2}", c.Id, c.Name, c.Salary);
            }

            int index = customers.FindIndex(cust => cust.Salary > 5000);

            Console.WriteLine("Index" + index);

            int index1 = customers.FindLastIndex(cust => cust.Salary > 5000);

            Console.WriteLine("Index" + index1);
        }

        public void ConvertingArrayToList()
        {
            Customer[] customers = CustomerTestData.GetCustomersArray();

            List<Customer> customers1 = customers.ToList();

            foreach (Customer customer in customers1)
            {
                Console.WriteLine("ID={0}, Name = {1},Salary= {2}", customer.Id, customer.Name, customer.Salary);
            }
        }

        public void ConvertingListToArray()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer[] customers2 = customers.ToArray();

            foreach (Customer customer in customers2)
            {
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", customer.Id, customer.Name, customer.Salary);
            }
        }

        public void ConvertingListToDictionary()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Dictionary<int, Customer> customers2 = customers.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int, Customer> kvp in customers2)
            {
                Console.WriteLine("Key" + kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("ID={0}, Name = {1},Salary= {2}", c.Id, c.Name, c.Salary);
            }
        }
    }
}
