using System;
using Day18Concepts.WhereOperatorsConcepts;
using Day18Concepts.OfTypeMethodConcepts;
using Day18Concepts.OrderByMethodConcepts;
using Day18Concepts.OrderByDescendingMethodConcepts;
using Day18Concepts.ReverseMethodConcepts;

namespace Day18Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhereOperators whereOperators = new WhereOperators();
            //whereOperators.WhereOperatorExampleQuerySyntaxExample1();
            //whereOperators.WhereOperatorExampleMethodSyntaxExample1();
            //whereOperators.WhereOperatorExampleQuerySyntaxExample2();
            //whereOperators.WhereOperatorExampleMethodSyntaxExample2();
            //whereOperators.WhereOperatorExampleQuerySyntaxExample3();
            //whereOperators.WhereOperatorExampleMethodSyntaxExample3();

            //OfTypeMethod ofTypeMethod = new OfTypeMethod();
            //ofTypeMethod.OfTypeMethodExampleUsingMethodSyntax();
            //ofTypeMethod.OfTypeMethodExampleUsingQuerySyntax();

            OrderByMethod orderByMethod = new OrderByMethod();
            //orderByMethod.OrderByMethodUsingQuerySyntaxExample1();
            //orderByMethod.OrderByMethodUsingMethodSyntaxExample1();
            //orderByMethod.OrderByMethodUsingQuerySyntaxExample2();
            //orderByMethod.OrderByMethodUsingMethodSyntaxExample2();
            orderByMethod.OrderByMethodandFilterUsingMethodSyntaxExample();
            //orderByMethod.OrderByMethodOnObjectsUsingQuerySyntaxExample();
            //orderByMethod.OrderByMethodOnObjectsUsingMethodSyntaxExample();

            OrderByDescendingMethod orderByDescendingMethod = new OrderByDescendingMethod();
            //orderByDescendingMethod.OrderByDescendingMethodUsingQuerySyntaxExample1();
            //orderByDescendingMethod.OrderByDescendingMethodUsingMethodSyntaxExample1();
            //orderByDescendingMethod.OrderByDescendingMethodUsingQuerySyntaxExample2();
            //orderByDescendingMethod.OrderByDescendingMethodUsingMethodSyntaxExample2();
            //orderByDescendingMethod.OrderByDescendingMethodandFilterUsingMethodSyntaxExample();
            //orderByDescendingMethod.OrderByDescendingMethodOnObjectsUsingQuerySyntaxExample();
            //orderByDescendingMethod.OrderByDescendingMethodOnObjectsUsingMethodSyntaxExample();

            ReverseMethod reverseMethod = new ReverseMethod();
            //reverseMethod.ReverseMethodConceptsMethodSyntaxExample1();
            //reverseMethod.ReverseMethodConceptsQuerySyntaxExample1();
            //reverseMethod.ReverseMethodConceptsMethodSyntaxExample2();

        }
    }
}
