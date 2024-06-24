using System;
using Day35Concepts.Generics;
using Day35Concepts.ListClass;
using Day35Concepts.ComparisionDelegate;
using Day35Concepts.DictionaryConcepts;
using Day35Concepts.CustomTypeAsADictionary;
using Day35Concepts.SortedListAndDictionary;
using Day35Concepts.GenericStackConcepts;
using Day35Concepts.GenericQueueConcepts;

namespace Day35Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericsTopic.GenericsExample();
            GenericsTopic.GenericsExample2();
            GenericsTopic.GenericsExample3();

            ClassGenericsExample();
            ClassGenericsExample2();

            ListClassExamples();

            ListClassFunctionsExamples();
            
            ListClassRangeExamples();

            ListOfSimpleTypesExamples();

            ListOfComplexTypesExamples();

            ComparisionDelegateExamples();

            DictionaryExamples();

            CountryCode.CustomTypeAsADictionaryExample();

            SortedDictionaryAndSortedListExamples();

            GenericStackExamples();

            GenericQueueExamples();
        }

        static void ClassGenericsExample()
        {
            bool equal = Calculator<int>.AreEqual(10, 10);

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        static void ClassGenericsExample2()
        {
            bool equal = Calculator<string>.AreEqual2("Siva", "Eknadh");

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        static void ListClassExamples()
        {
            ListClassExamples listClassExamples = new ListClassExamples();
            listClassExamples.ListClassExamples1();
            listClassExamples.InsertingAnObject();
        }

        static void ListClassFunctionsExamples()
        {
            ListClassFunctions listClassFunctions = new ListClassFunctions();
            listClassFunctions.ListClassContainsFunctionExamples();
            listClassFunctions.FindingItemsInAList();
            listClassFunctions.ConvertingArrayToList();
            listClassFunctions.ConvertingListToArray();
            listClassFunctions.ConvertingListToDictionary();
        }

        static void ListClassRangeExamples()
        {
            ListClassRange listClassRange = new ListClassRange();
            listClassRange.ListClassRangeExamples();
            listClassRange.ListClassRemoveRangeExamples();
        }

        static void ListOfSimpleTypesExamples()
        {
            ListOfSimpleType listOfSimpleType = new ListOfSimpleType();
            listOfSimpleType.ListOfSimpleTypeExample1();
            listOfSimpleType.ListOfSimpleTypeExample2();
        }

        static void ListOfComplexTypesExamples()
        {
            ListOfComplexTypes listOfComplexTypes = new ListOfComplexTypes();
            listOfComplexTypes.ListOfComplexTypesExamples();
        }

        static void ComparisionDelegateExamples()
        {
            ComparisionDelegateTopic comparisionDelegateTopic = new ComparisionDelegateTopic();
            comparisionDelegateTopic.ComparisionDelegateExamples();
        }

        static void DictionaryExamples()
        {
            Dictionary dictionary = new Dictionary();
            dictionary.DictionaryConceptsExamples1();
            dictionary.DictionaryExamples2();
            dictionary.DictionaryExamples3();
            dictionary.DictionaryExamples4();
        }

        static void SortedDictionaryAndSortedListExamples()
        {
            SortedListsAndDictionary sortedListsAndDictionary = new SortedListsAndDictionary();
            sortedListsAndDictionary.SortedDictionaryExample();
            sortedListsAndDictionary.SortedDictionaryExample2();
            sortedListsAndDictionary.SortedListExample2();
        }

        static void GenericStackExamples()
        {
            GenericStack genericStack = new GenericStack();
            genericStack.GerericStackExamples();
            genericStack.ShoppingCartExample();
        }

        static void GenericQueueExamples()
        {
            GenericQueueConcept genericQueueConcept = new GenericQueueConcept();
            genericQueueConcept.QueueConceptsExamples();
            genericQueueConcept.MovieBookingSytemExample();
        }
    }
}
