using System;
using Day20Concepts.PartitionOperatorTakeMethod;
using Day20Concepts.SkipMethodConcepts;
using Day20Concepts.TakeWhileMethodConcepts;
using Day20Concepts.SkipWhileMethodConcepts;
using Day20Concepts.FirstAndFirstOrDefaultMethodConcepts;
using Day20Concepts.LastAndLastOrDefaultMethodConcepts;
using Day20Concepts.SingleAndSingleOrDefaultMethodConcepts;

namespace Day20Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TakeMethod takeMethod = new TakeMethod();
            takeMethod.MethodSyntaxExample1();
            takeMethod.MixedSyntaxExample1();

            TakeWhileMethod takeWhileMethod = new TakeWhileMethod();
            takeWhileMethod.MethodSytaxExample1();
            takeWhileMethod.MixedSytaxExample1();
            takeWhileMethod.MethodSytaxExample2();
            takeWhileMethod.MixedSytaxExample2();

            SkipMethod skipMethod = new SkipMethod();
            skipMethod.MethodSyntaxExample1();
            skipMethod.MixedSytaxExample1();
            skipMethod.MethodSytaxExample2();
            skipMethod.MixedSytaxExample2();

            SkipWhileMethod skipWhileMethod = new SkipWhileMethod();
            skipWhileMethod.MethodSyntaxExample1();
            skipWhileMethod.MixedSyntaxExample1();
            skipWhileMethod.MethodSytaxExample2();
            skipWhileMethod.MethodSytaxExample3();

            FirstAndFirstOrDefaultMethod firstAndFirstOrDefaultMethod = new FirstAndFirstOrDefaultMethod();
            firstAndFirstOrDefaultMethod.MethodSyntaxExample1();
            firstAndFirstOrDefaultMethod.MethodSyntaxExample2();
            firstAndFirstOrDefaultMethod.MethodSyntaxExample3();
            firstAndFirstOrDefaultMethod.MethodSyntaxExample4();
            firstAndFirstOrDefaultMethod.MethodSyntaxExampleforFirstOrDefaultMethod();
            firstAndFirstOrDefaultMethod.MixedSyntaxExample1();
            firstAndFirstOrDefaultMethod.MixedSyntaxExampleforFirstOrDefaultMethod();

            LastAndLastOrDefaultMethod lastAndLastOrDefaultMethod = new LastAndLastOrDefaultMethod();
            lastAndLastOrDefaultMethod.MethodSyntaxExample1();
            lastAndLastOrDefaultMethod.MethodSyntaxExample2();
            lastAndLastOrDefaultMethod.MethodSyntaxExample3();
            lastAndLastOrDefaultMethod.MethodSyntaxExample4();
            lastAndLastOrDefaultMethod.MethodSyntaxExample5();
            lastAndLastOrDefaultMethod.MethodSyntaxExampleforLastOrDefaultMethod();
            lastAndLastOrDefaultMethod.MixedSyntaxExample1();
            lastAndLastOrDefaultMethod.MixedSyntaxExampleforLastOrDefaultMethod();

            SingleAndSingleOrDefaultMethod singleAndSingleOrDefaultMethod = new SingleAndSingleOrDefaultMethod();
            singleAndSingleOrDefaultMethod.MethodSyntaxExample1();
            singleAndSingleOrDefaultMethod.MethodSyntaxExample2();
            singleAndSingleOrDefaultMethod.MethodSyntaxExample3();
            singleAndSingleOrDefaultMethod.MixedSyntaxExample1();
            singleAndSingleOrDefaultMethod.MixedSyntaxExample2();
        }
    }
}
