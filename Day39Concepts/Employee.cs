using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeProgram : Employee
    {
        public List<string> Programming { get; set; }
    }

    public class EmployeeTech : Employee
    {
        public string Technology { get; set; }
        public List<EmployeeTech> Programming { get; set; }
    }
}
