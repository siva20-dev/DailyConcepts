using System;
using System.Collections.Generic;
using Day13Concepts.DictionaryConcepts;
using Day13Concepts.CustomTypeAsADictionary;
using Day13Concepts.SortedListAndDictionary;
using Day13Concepts.GenericStackConcepts;
using Day13Concepts.QueueConcepts;


namespace Day13Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryConceptExample.DictionaryConceptsExamples1();
            CountryCode.CustomTypeAsADictionaryExample();
            SortedListsAndDictionary.SortedDictionaryExample();

            GenericStack.GerericStackExamples();
            GenericStack.ShoppingCartExample();

            QueueConcept.QueueConceptsExamples();
            QueueConcept.MovieBookingSytemExample();
        }
    }
}
