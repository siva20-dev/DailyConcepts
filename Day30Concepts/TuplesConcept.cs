using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts.TuplesConcept
{
    public class Tuples
    {
        
        public static void TuplesExample1()
        {
            Tuple<int, string, double> emp = new Tuple<int, string, double>(121,"Thomas",30000);
            Console.WriteLine(emp.Item1);
        }

        public static void TuplesExample2()
        {
            var emp = Tuple.Create(131, "Siva", 130000);
            Console.WriteLine(emp.Item3);
        }

        public static (int empId,string empName, double empSalary) GetEmployees()
        {
            return (1, "Siva", 20000);
        }

        public static (int empId, string empName, double empSalary) GetEmployees2()
        {
            var emp = (eid:0,ename:string.Empty,salary:0.0);

            emp.eid = 130;
            emp.ename = "Rohit";
            emp.salary = 30000;

            return emp;

        }
    }
}
