using System;
using Interfaceconcepts = Day33Concepts.Interfaces;
using Day33Concepts.ExplicitInterfaceImplementations;
using abstractclass = Day33Concepts.AbstractClasses;
using Day33Concepts.AbstractClasses;
using Day33Concepts.MultipleInheritance;
using Day33Concepts.OptionalParameters;
using overrideToString = Day33Concepts.OverrideToStringMethod;
using convertStringVSToString = Day33Concepts.ConvertStringVSToString;
using Day33Concepts.ConstantReadonly;
using Day33Concepts.StringAndStringBuilder;

namespace Day33Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceConcepts();

            ExplicitInterfaceImplementation();

            AbstractClassConcepts();

            MultipleInheritanceConcepts();

            ParameterArrayExamples();
            ParameterArrayExamples2();

            MethodOverLoadingExample1();
            MethodOverLoadingExample2();

            ParameterDefaultsExample1();
            ParameterDefaultsExample2();

            OptionalAttributesExample1();
            OptionalAttributesExample2();

            OverrideToStringMethodExample();

            ConvertToStringVSToStringExample();

            StringAndStringBuilderExample();

            ConstantReadOnlyAndStaticExample();
        }

        static void InterfaceConcepts()
        {
            Interfaceconcepts.Customer customer = new Interfaceconcepts.Customer();
            customer.Print();
            customer.I2Method();

            Interfaceconcepts.ICustomer customer1 = new Interfaceconcepts.Customer();
            customer1.Print();
        }

        static void ExplicitInterfaceImplementation()
        {
            ExplicitInterfaceImplementation P = new ExplicitInterfaceImplementation();
            ((I1)P).InterfaceMethod();
            ((I3)P).InterfaceMethod();
            //or
            I1 p1 = new ExplicitInterfaceImplementation();
            I3 p3 = new ExplicitInterfaceImplementation();
            p1.InterfaceMethod();
            p3.InterfaceMethod();
        }

        static void AbstractClassConcepts()
        {
            AbstractClassConcept abstractClassConcept = new AbstractClassConcept();
            abstractClassConcept.Print();
            //or
            abstractclass.Customer Cust = new AbstractClassConcept();
            Cust.Print();
        }

        static void MultipleInheritanceConcepts()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }

        static void ParameterArrayExamples()
        {
            ParameterArray parameterArray = new ParameterArray();
            parameterArray.AddNumbers(10, 20);
            parameterArray.AddNumbers(10, 20, new object[] { 1, 2, });
        }

        static void ParameterArrayExamples2()
        {
            ParameterArray parameterArray = new ParameterArray();
            parameterArray.LogMessage("System Started");
            parameterArray.LogMessage("System Started", 2);
            parameterArray.LogMessage("System started", 2, "User: Admin", "IP: 127.0.0.1");
        }

        static void MethodOverLoadingExample1()
        {
            OptionalParameterMethodOverLoading methodOverLoading = new OptionalParameterMethodOverLoading();
            methodOverLoading.AddNumbers(10, 20);
            methodOverLoading.AddNumbers(10, 20, new int[] { 1, 2, 3 });
        }

        static void MethodOverLoadingExample2()
        {
            OptionalParameterMethodOverLoading methodOverLoading = new OptionalParameterMethodOverLoading();
            methodOverLoading.LogMessage("System started");
            methodOverLoading.LogMessage("System error", true);
            methodOverLoading.LogMessage("System maintenance", false, new DateTime(2023, 6, 12, 14, 30, 0));
        }

        static void ParameterDefaultsExample1()
        {
            ParameterDefaults parameterDefaults = new ParameterDefaults();
            parameterDefaults.AddNumbers(10, 20);
            parameterDefaults.AddNumbers(10, 20, new int[] { 10, 20 });

            parameterDefaults.Test(1);
            parameterDefaults.Test(1, 2);
            parameterDefaults.Test(1, number3: 3);
        }

        static void ParameterDefaultsExample2()
        {
            ParameterDefaults parameterDefaults = new ParameterDefaults();
            parameterDefaults.RecordEvent("User login");
            parameterDefaults.RecordEvent("System error", isImportant: true, eventId: 101);
            parameterDefaults.RecordEvent("Data backup", eventId: 200);
        }

        static void OptionalAttributesExample1()
        {
            OptionalAttributes optionalAttributes = new OptionalAttributes();
            optionalAttributes.AddNumbers(10, 20);
            optionalAttributes.AddNumbers(10, 20, new int[] { 10 });
        }

        static void OptionalAttributesExample2()
        {
            OptionalAttributes optionalAttributes = new OptionalAttributes();
            optionalAttributes.DrawSymbol();
            optionalAttributes.DrawSymbol('#');
            optionalAttributes.DrawSymbol('!', isVisible: false, opacity: 0.5f);
        }

        static void OverrideToStringMethodExample()
        {
            overrideToString.OverrideToStringMethod overrideToStringMethod = new overrideToString.OverrideToStringMethod();
            overrideToStringMethod.OverrideToStringMethodExample();

            overrideToString.Customer C1 = new overrideToString.Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";
            Console.WriteLine(C1.ToString());
            //or
            Console.WriteLine(Convert.ToString(C1));
        }

        static void ConvertToStringVSToStringExample()
        {
            convertStringVSToString.Customer customer = null;
            string name = Convert.ToString(customer);
            Console.WriteLine(name);
        }

        static void StringAndStringBuilderExample()
        {
            StringAndStringBuilderTopic stringAndStringBuilder = new StringAndStringBuilderTopic();
            stringAndStringBuilder.StringExample();
            stringAndStringBuilder.StringBuilderExample();
        }

        static void ConstantReadOnlyAndStaticExample()
        {
            ConstantReadonlyConcept constantReadonly = new ConstantReadonly.ConstantReadonlyConcept();
            constantReadonly.ConstantReadonlyExample();

            Static instance1 = new Static();
            Static instance2 = new Static();
            Static instance3 = new Static();
            Static instance4 = new Static();
        }
    }
}
