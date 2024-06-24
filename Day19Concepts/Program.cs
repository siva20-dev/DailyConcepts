using System;
using Day19Concepts.QuantifierAllMethodConcepts;
using Day19Concepts.AnyOperatorMethodConcepts;
using Day19Concepts.ContainsMethodConcepts;
using Day19Concepts.DistinctOperatorConcepts;
using Day19Concepts.ExceptMethodConcepts;
using Day19Concepts.IntersectMethodConcepts;
using Day19Concepts.UnionMethodConcepts;


namespace Day19Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuantifierAllMethod quantifierAllMethod = new QuantifierAllMethod();
            quantifierAllMethod.QuantifierAllMethodExampleUsingMethodSyntax();
            quantifierAllMethod.QuantifierAllMethodExampleUsingQuerySyntax();
            quantifierAllMethod.QuantifierAllMethodUsingMethodSyntaxExample2();
            quantifierAllMethod.QuantifierAllMethodUsingQuerySyntaxExample2();

            AnyOperatorMethod anyOperatorMethod = new AnyOperatorMethod();
            anyOperatorMethod.AnyOperatorMethodExample1();
            anyOperatorMethod.AnyOperatorMethodSyntaxExample();
            anyOperatorMethod.AnyOperatorMethodExampleUsingQuerySyntax();
            anyOperatorMethod.AnyOperatorMethodSyntaxExample2();
            anyOperatorMethod.AnyOperatorQuerySyntaxExample2();

            ContainsMethod containsMethod = new ContainsMethod();
            containsMethod.ContainsMethodExample1();
            containsMethod.ContainsMethodExample2();

            DistinctOperatorMethod distinctOperator = new DistinctOperatorMethod();
            distinctOperator.MethodSyntaxExample1();
            distinctOperator.QuerySyntaxExample1();
            distinctOperator.MethodSyntaxExample2();
            distinctOperator.MixedSyntaxExample2();
            distinctOperator.MethodSyntaxWithIEqualityComparer();
            distinctOperator.MethodSyntaxWithIEquatableMethod();

            ExceptMethod except = new ExceptMethod();
            except.MethodSyntaxExample1();
            except.MethodSyntaxExample2();
            except.MethodSyntaxUsingAnonymousMethod();
            except.MethodSyntaxUsingIEqualityComparerMethod();
            except.MixedSyntaxUsingIEqualityComparerMethod();

            IntersectMethod intersect = new IntersectMethod();
            intersect.MethodSyntaxExample1();
            intersect.MixedSyntaxExample1();
            intersect.MethodSyntaxUsingAnonymousMethod();
            intersect.MethodSyntaxUsingIEqualityComparerMethod();

            UnionMethod union = new UnionMethod();
            union.MethodSyntaxExample1();
            union.MixedSyntaxExample1();
            union.MethodSyntaxUsingAnonymousMethod();
            union.MethodSyntaxUsingIEqualityComparerMethod();
        }
    }
}
