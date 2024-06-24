using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.TuplesConcepts
{
    public class TuplesConcept
    {
        public static void TuplesConceptExample1()
        {
            Tuple<int, string, double> obj = new Tuple<int, string, double>(121, "Thomas", 300000);

            var emp = Tuple.Create(121, "Thomas", 300000);
        }

        public static Tuple<int, string, double> GetEmployees()
        {
            return new Tuple<int, string, double>(141, "John", 400000);
        }

        public static (int, string, double) GetEmployees2()
        {
            return (151, "Sam", 400000);
        }

        public static (int EmpId, string EmpName, double EmpSalary) GetEmployees3()
        {
            return (151, "Sam", 400000);
        }

        public static (int EmpId, string EmpName, double EmpSalary) GetEmployees4()
        {
            var em = (eid: 0, ename: String.Empty, Salary: 0.0);

            em.eid = 1331;

            em.ename = "Luise";

            double sal = 30000 * 12;
            em.Salary = sal;

            return em;
        }

        public static void TuplesConceptsExamples()
        {
            var emp1 = TuplesConcept.GetEmployees();
            Console.WriteLine($"EmpId# {emp1.Item1},{emp1.Item2} has Salary Rs.{emp1.Item3}");

            var emp2 = TuplesConcept.GetEmployees2();
            Console.WriteLine($"EmpId# {emp2.Item1},{emp2.Item2} has Salary Rs.{emp2.Item3}");

            var emp3 = TuplesConcept.GetEmployees3();
            Console.WriteLine($"EmpId# {emp3.EmpId},{emp3.EmpName} has Salary Rs.{emp3.EmpSalary}");

            var emp4 = TuplesConcept.GetEmployees4();
            Console.WriteLine($"EmpId# {emp4.EmpId},{emp4.EmpName} has Salary Rs.{emp4.EmpSalary}");
        }
    }
}
