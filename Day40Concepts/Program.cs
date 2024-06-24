using System;
using Day40Concepts.QuantifierOperators;
using Day40Concepts.SetOperatorsDistinctMethod;
using Day40Concepts.SetOperatorsExceptMethod;
using Day40Concepts.PartitioningOperators;
using Day40Concepts.ElementOperators;


namespace Day40Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllMethod allMethod = new AllMethod();
            allMethod.Example1();
            allMethod.Example2();

            AnyMethod anyMethod = new AnyMethod();
            anyMethod.Example1();
            anyMethod.Example2();
            anyMethod.Example3();

            ContainsMethod containsMethod = new ContainsMethod();
            containsMethod.Example1();
            containsMethod.Example2();

            DistinctMethod distinctMethod = new DistinctMethod();
            distinctMethod.Example1();
            distinctMethod.Example2();
            distinctMethod.IEquatableMethodExample();
            distinctMethod.IEqualityComparerExample();

            ExceptMethod exceptMethod = new ExceptMethod();
            exceptMethod.Example1();
            exceptMethod.Example2();
            exceptMethod.AnonymousMethodExample();
            exceptMethod.IEqualityComparerMethodExample();

            IntersectMethod intersectMethod = new IntersectMethod();
            intersectMethod.Example1();
            intersectMethod.AnonymousMethodExample();
            intersectMethod.IEqualityComparerMethodExample();

            UnionMethod unionMethod = new UnionMethod();
            unionMethod.Example1();
            unionMethod.AnonymousMethodExample();
            unionMethod.IEqualityComparerMethodExample();

            TakeMethod takeMethod = new TakeMethod();
            takeMethod.Example1();

            TakeWhileMethod takeWhileMethod = new TakeWhileMethod();
            takeWhileMethod.Example1();
            takeWhileMethod.Example2();

            SkipMethod skipMethod = new SkipMethod();
            skipMethod.Example1();
            skipMethod.Example2();

            SkipWhileMethod skipWhileMethod = new SkipWhileMethod();
            skipWhileMethod.Example1();
            skipWhileMethod.Example2();
            skipWhileMethod.Example3();

            FirstAndFirstOrDefaultMethod firstAndFirstOrDefaultMethod = new FirstAndFirstOrDefaultMethod();
            firstAndFirstOrDefaultMethod.Example1();
            firstAndFirstOrDefaultMethod.Example2();
            firstAndFirstOrDefaultMethod.Example3();
            firstAndFirstOrDefaultMethod.Example4();
            firstAndFirstOrDefaultMethod.Example5();

            LastAndLastOrDefault lastAndLastOrDefault = new LastAndLastOrDefault();
            lastAndLastOrDefault.Example1();
            lastAndLastOrDefault.Example2();
            lastAndLastOrDefault.Example3();
            lastAndLastOrDefault.Example4();

            SingleAndSingleOrDefault singleAndSingleOrDefault = new SingleAndSingleOrDefault();
            singleAndSingleOrDefault.Example1();
            singleAndSingleOrDefault.Example2();
            singleAndSingleOrDefault.Example3();
        }
    }
}
