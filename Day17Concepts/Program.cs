using System;
using Day17Concepts.LINQConcepts;
using Day17Concepts.ExtensionMethods;
using Day17Concepts.ProjectionOperatorSelectMethod;
using Day17Concepts.SelectManyMethodConcept;

namespace Day17Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQConcept linqConcepts = new LINQConcept();
            linqConcepts.QuerySyntaxExample();
            linqConcepts.MethodSyntaxExample();
            linqConcepts.MixedSyntaxExample();

            ExtensionMethod extensionMethod = new ExtensionMethod();
            extensionMethod.ExtensionMethodsExample();

            SelectMethod selectMethod = new SelectMethod();
            selectMethod.SelectMethodExampleUsingQuerySyntax();
            selectMethod.SelectMethodExampleUsingQuerySyntaxExample1();
            selectMethod.SelectMethodExampleUsingMethodSyntaxExample1();
            selectMethod.ConvertingDataFromOneClassToAnotherClassQuerySyntax();
            selectMethod.ConvertingDataFromOneClassToAnotherClassMethodSyntax();
            selectMethod.ConvertingDataFromOneClassToAnonymousClassQuerySyntax();
            selectMethod.ConvertingDataFromOneClassToAnonymousClassMethodSyntax();
            selectMethod.SelectingTheDataInTheIndexExample();

            SelectManyMethod selectManyMethod = new SelectManyMethod();
            selectManyMethod.SelectManyMethodExample();
            selectManyMethod.SelectManyMethodExample2();
            selectManyMethod.SelectManyMethodQuerySyntaxExample();
            selectManyMethod.SelectManyMethodExample3();
            selectManyMethod.SelectManyMethodExample4();
        }
    }
}
