using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts
{
    public class CustomerTestData
    {
        public static List<Customer> GetCustomers()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                Id = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                Id = 1,
                Name = "John",
                Salary = 3500
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }

        public static Customer[] GetCustomersArray()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                Id = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                Id = 119,
                Name = "Rob",
                Salary = 5500
            };

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            return customers;
        }

        public static List<CustomerType> GetCustomersTypes()
        {
            CustomerType customer1 = new CustomerType()
            {
                Id = 101,
                Name = "Mark",
                Salary = 5000,
                Type = "RetailCustomer"
            };

            CustomerType customer2 = new CustomerType()
            {
                Id = 102,
                Name = "Pam",
                Salary = 6500,
                Type = "RetailCustomer"
            };

            CustomerType customer3 = new CustomerType()
            {
                Id = 103,
                Name = "John",
                Salary = 3500,
                Type = "RetailCustomer"
            };

            CustomerType customer4 = new CustomerType()
            {
                Id = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            CustomerType customer5 = new CustomerType()
            {
                Id = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<CustomerType> customersType = new List<CustomerType>();

            customersType.Add(customer1);
            customersType.Add(customer2);
            customersType.Add(customer3);
            customersType.Add(customer4);
            customersType.Add(customer5);

            return customersType;
        }

        public static List<CustomerCompare> GetCustomersCompareTypes()
        {
            CustomerCompare customer1 = new CustomerCompare()
            {
                Id = 101,
                Name = "Mark",
                Salary = 5000
            };

            CustomerCompare customer2 = new CustomerCompare()
            {
                Id = 102,
                Name = "Pam",
                Salary = 6500
            };

            CustomerCompare customer3 = new CustomerCompare()
            {
                Id = 103,
                Name = "John",
                Salary = 3500
            };

            List<CustomerCompare> customers = new List<CustomerCompare>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }
    }
}
