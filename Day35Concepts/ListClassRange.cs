using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClass
{
    public class ListClassRange
    {
        public void ListClassRangeExamples()
        {
            List<CustomerType> customersType = CustomerTestData.GetCustomersTypes();

            foreach (CustomerType customer in customersType)
            {
                Console.WriteLine("ID={0}, Name={1},Salary={2},Type={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            List<CustomerType> customersType1 = customersType.GetRange(3, 2);

            foreach (CustomerType custom in customersType1)
            {
                Console.WriteLine("ID={0}, Name={1},Salary={2},Type={3}", custom.Id, custom.Name, custom.Salary, custom.Type);
            }

            List<CustomerType> customersType2 = customersType.GetRange(0, 2);

            foreach (CustomerType cust in customersType2)
            {
                Console.WriteLine("ID={0}, Name={1},Salary={2},Type={3}", cust.Id, cust.Name, cust.Salary, cust.Type);
            }
        }

        public void ListClassRemoveRangeExamples()
        {
            List<CustomerType> customersType = CustomerTestData.GetCustomersTypes();

            customersType.InsertRange(0, customersType);
            customersType.RemoveRange(0, 3);

            customersType.RemoveAt(1);
            customersType.RemoveAll(x => x.Type == "RetailCustomer");

            foreach (CustomerType cus in customersType)
            {
                Console.WriteLine("ID={0}, Name={1},Salary={2},Type={3}", cus.Id, cus.Name, cus.Salary, cus.Type);
            }
        }
    }
}
