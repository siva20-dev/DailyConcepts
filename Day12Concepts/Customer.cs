using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class Customer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class CustomerType : Customer
    {
        public string Type { get; set; }
    }

    public class CustomerCompare : IComparable<CustomerCompare>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(CustomerCompare other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
