using System;
using System.Collections.Generic;

namespace Day18Concepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
    }

    public class EmployeeTech : Employee
    {
        public string Technology { get; set; }
        public List<EmployeeTech> Programming { get; set; }
    }
}
