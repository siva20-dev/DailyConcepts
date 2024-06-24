using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClass
{
    public class ListOfComplexTypes
    {
        public void ListOfComplexTypesExamples()
        {
            List<CustomerCompare> customers = CustomerTestData.GetCustomersCompareTypes();


            Console.WriteLine("Before Sorting");
            foreach (CustomerCompare customer in customers)
            {
                Console.WriteLine(customer.Salary);
            }

            customers.Sort();
            customers.Reverse();

            Console.WriteLine("After Sorting");
            foreach (CustomerCompare custom in customers)
            {
                Console.WriteLine(custom.Salary);
            }

            Console.WriteLine("Before Sorting");
            foreach (CustomerCompare cust in customers)
            {
                Console.WriteLine(cust.Name);
            }

            customers.Sort();
            customers.Reverse();

            Console.WriteLine("After Sorting");
            foreach (CustomerCompare cus in customers)
            {
                Console.WriteLine(cus.Name);
            }

            SortbyName sortbyName = new SortbyName();
            customers.Sort(sortbyName);

            Console.WriteLine("Sorting by Name");
            foreach (CustomerCompare c in customers)
            {
                Console.WriteLine(c.Name);
            }
        }
    }

    public class SortbyName : IComparer<CustomerCompare>
    {
        public int Compare(CustomerCompare x, CustomerCompare y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

