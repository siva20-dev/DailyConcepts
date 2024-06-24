using System;
using System.Collections.Generic;
using Day12Concepts;
using Day12Concepts.ListClassConcepts;
using System.Linq;
using Day12Concepts.ListClassFunctions;
using Day12Concepts.ListClassRange;
using Day12Concepts.ListofComplexTypes;
using Day12Concepts.ComparisionDelegate;

namespace Day12Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListClassConceptsExample.ListCollectionClassExamples();
            ListClassConceptsExample.ListAddFunctionExamples();
            ListClassConceptsExample.ListGetItemsExamples();

            ListClassFunctionsConcepts.ListClassContainsFunctionExamples();
            ListClassFunctionsConcepts.FindingItemsInAList();
            ListClassFunctionsConcepts.ConvertingArrayToList();
            ListClassFunctionsConcepts.ConvertingListToArray();
            ListClassFunctionsConcepts.ConvertingListToDictionary();

            ListClassRangeConcepts.ListClassRangeExamples();

            SortingComplexTypesConcepts.ListOfComplexTypesExamples();

            ComparisionDelegateConcepts.ComparisionDelegateExamples();
        }
    }
}
