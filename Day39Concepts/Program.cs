using System;
using Day39Concepts.WaysToWriteALINQQuery;
using Day39Concepts.ExtensionMethods;
using Day39Concepts.ProjectionOperators;
using System.Data.Common;
using Day39Concepts.FilteringOperators;
using Day39Concepts.SortingOperators;

namespace Day39Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQConcepts lINQConcepts = new LINQConcepts();
            lINQConcepts.LinqQueryExamples();

            ExtensionMethod extensionMethod = new ExtensionMethod();
            extensionMethod.ExtensionMethodsExample();

            SelectMethod selectMethod = new SelectMethod();
            selectMethod.MethodSyntaxExample1();
            selectMethod.BindingDataToAnotherClass();
            selectMethod.BindingDataToAnonymousClass();
            selectMethod.SelectingTheDataInTheIndexExample();

            SelectManyMethod selectManyMethod = new SelectManyMethod();
            selectManyMethod.Example1();
            selectManyMethod.Example2();
            selectManyMethod.Example3();

            WhereMethod whereMethod = new WhereMethod();
            whereMethod.Example1();
            whereMethod.Example2();
            whereMethod.Example3();

            OfTypeMethod ofTypeMethod = new OfTypeMethod();
            ofTypeMethod.Example1();

            OrderByMethod orderByMethod = new OrderByMethod();
            orderByMethod.Example1();
            orderByMethod.Example2();
            orderByMethod.Example3();
            orderByMethod.Example4();

            OrderByDescendingMethod orderByDescendingMethod = new OrderByDescendingMethod();
            orderByDescendingMethod.Example1();
            orderByDescendingMethod.Example2();
            orderByDescendingMethod.Example3();
            orderByDescendingMethod.Example4();

            ReverseMethod reverseMethod = new ReverseMethod();
            reverseMethod.Example1();
            reverseMethod.Example2();
        }
    }
}
