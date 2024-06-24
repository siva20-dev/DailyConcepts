using System;
using Day30Concepts.OperatorConcepts;
using Day30Concepts.IfStatementConcepts;
using Day30Concepts.SwitchStatementConcepts;
using Day30Concepts.SwitchStatementContinuedConcepts;
using Day30Concepts.NullCoalescingOperatorConcept;
using Day30Concepts.WhileLoopConcept;
using Day30Concepts.DoWhileLoopConcept;
using Day30Concepts.ForAndForEachLoopConcepts;
using Day30Concepts.MethodsConcept;
using Day30Concepts.MethodParameterConcepts;
using System.Diagnostics.CodeAnalysis;
using Day30Concepts.OutAndRefParametersConcept;
using Day30Concepts.TuplesConcept;

namespace Day30Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators.AssignmentOperatorExample();
            //Operators.ArithmeticOperatorExample();
            //Operators.ComparisonOperatorExample();
            //Operators.AndOperatorExample();
            //Operators.OrOperatorExample();
            //Operators.TerinaryOperatorExample();

            //IfStatement.IfStatementExample();
            //IfStatement.IfStatementExample2();
            //IfStatement.IfStatementExample3();
            //IfStatement.IfStatementExampleWithString();

            //SwitchStatement.SwitchStatementExample1();
            //SwitchStatement.SwitchStatementExample2();

            //SwitchStatementContinued.CoffeePurchaseExample();

            //NullCoalescingOperator.NullCoalescingOperatorExample();
            //WhileLoop.WhileLoopExample();

            //DoWhileLoop.DoWhileLoopExample();
            //DoWhileLoop.DoWhileLoopExampleUsingStrings();
            //DoWhileLoop.CoffeePurchaseExample();

            //ForAndForEachLoop.WhileLoopExample();
            //ForAndForEachLoop.StringWhileLoopExample();
            //ForAndForEachLoop.ForLoopExample();
            //ForAndForEachLoop.StringForLoopExample();
            //ForAndForEachLoop.ForEachLoopExample();
            //ForAndForEachLoop.StringForEachLoopExample();
            //ForAndForEachLoop.ForLoopWithBreakStatementExample();
            //ForAndForEachLoop.ForLoopWithContinueStatementExample();

            //Methods methods = new Methods();
            //methods.InstanceMethodExample();

            //Methods.StaticMethodExample();
            //Methods.MethodWithParameterExample(30);

            //int sum = Methods.MethodWithReturnExample(10, 20);
            //Console.WriteLine(sum);

            MethodParametersExample();

            //int number2 = 20;
            //OutAndRefParameters.ReferenceParameterExample(ref number2);
            //Console.WriteLine(number2);

            //OutAndRefParameters.OutParameterExample(out number2);
            //Console.WriteLine(number2);

            //Tuples.TuplesExample1();
            //Tuples.TuplesExample2();

            //var emp = Tuples.GetEmployees();
            //Console.WriteLine($"Employee Id{emp.empId},EmployeeName {emp.empName} has salary {emp.empSalary}");

            //var emp = Tuples.GetEmployees2();
            //Console.WriteLine($"Employee Id{emp.empId},EmployeeName {emp.empName} has salary {emp.empSalary}");
        }

        public static void MethodParametersExample()
        {
            int number1 = 0;
            MethodParameter.ValueParameterExample(number1);
            Console.WriteLine(number1);

            int number2 = 0;
            MethodParameter.ReferenceParameterExample(ref number2);
            Console.WriteLine(number2);

            int sum = 0;
            int product = 0;
            MethodParameter.OutParameterExample(10, 20, out sum, out product);
            Console.WriteLine("Sum = {0} && Product = {1}", sum, product);

            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            MethodParameter.ParameterArrayExample(numbers);
            MethodParameter.ParameterArrayExample();
            MethodParameter.ParameterArrayExample(1, 2, 3);
        }
    }
}
