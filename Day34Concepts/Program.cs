using System;
using whyenums = Day34Concepts.WhyEnums;
using enums = Day34Concepts.Enums;
using Day34Concepts.Enums2;
using Day34Concepts.ExceptionHandlingConcept;
using Day34Concepts.ExceptionHandlingTypes;
using Day34Concepts.AsynchronusProgramming;
using System.Threading;
using System.Threading.Tasks;
using Day34Concepts.DebugVSReleaseMode;
using Day34Concepts.Arrays;
using Day34Concepts.ComparingArrays;

namespace Day34Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            whyenums.Customer.WhyEnumsExample();

            enums.Customer customer = new enums.Customer();
            customer.EnumsExample();

            Enums2.Enums enums = new Enums2.Enums();
            enums.EnumExamples();

            ExceptionHandlingExamples();

            ThreadAndTaskExample();

            AsynchronusProgrammingExample();

            DebugVSReleaseModeTopic debugVSReleaseMode = new DebugVSReleaseModeTopic();
            debugVSReleaseMode.Method1();
            debugVSReleaseMode.DebugVSReleaseModeExample();

            ArraysConcept arraysConcept = new ArraysConcept();
            arraysConcept.ArrayExample1();
            arraysConcept.ModifyingAnArrayExample();
            arraysConcept.ArrayClassExampleMethods();

            ComparingArraysConcept comparingArrays = new ComparingArraysConcept();
            comparingArrays.DaysofWeek();
        }

        static void ThreadAndTaskExample()
        {
            AsynchronousProgrammingTopic asynchronousProgramming = new AsynchronousProgrammingTopic();

            Task t1 = new Task(asynchronousProgramming.PrintNumbers1);
            Task t2 = new Task(asynchronousProgramming.PrintNumbers2);
            t1.Start();
            t2.Start();
            Console.WriteLine("Hello World");
        }

        static void AsynchronusProgrammingExample()
        {
            AsynchronousProgrammingTopic asynchronusProgramming = new AsynchronousProgrammingTopic();
            asynchronusProgramming.PrintNumbers3();
            asynchronusProgramming.PrintNumbers4();
            Console.WriteLine("Hello World");
        }

        static void ExceptionHandlingExamples()
        {
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.TryCatchExample();
            ExceptionTypes.ExceptionTypesExample1();
            ExceptionTypes.ExceptionTypesExample2();
            ExceptionTypes.ExceptionTypesExample3();
            ExceptionTypes.ExceptionTypesExample4();
            ExceptionTypes.ExceptionTypesExample5();
        }
    }
}
