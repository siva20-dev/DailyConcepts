using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.SortedListAndDictionary
{
    public class SortedListsAndDictionary
    {
        public void SortedDictionaryExample()
        {
            var fileInfo = new SortedDictionary<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"Key:{kvp.Key},value:{kvp.Value}");
            }

            Console.WriteLine("Press any key to add another file extension");
            Console.ReadLine();
            fileInfo.Add("bmp", "paint.exe");

            Console.WriteLine("Updated file info");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"Key:{kvp.Key},value:{kvp.Value}");
            }
        }

        public void SortedDictionaryExample2()
        {
            SortedDictionary<string, long> countryPopulations = new SortedDictionary<string, long>();
            
            countryPopulations.Add("China", 1409517397);
            countryPopulations.Add("India", 1339180127);
            countryPopulations.Add("United States", 331002651);

            Console.WriteLine("Country Populations:");
            foreach (KeyValuePair<string, long> kvp in countryPopulations)
            {
                Console.WriteLine($"Country: {kvp.Key}, Population: {kvp.Value:N0}");
            }
        }

        public void SortedListExample2()
        {
            SortedList<int, decimal> employeeSalaries = new SortedList<int, decimal>();

            employeeSalaries.Add(102, 75000.50m);
            employeeSalaries.Add(101, 85000.75m);
            employeeSalaries.Add(103, 65000.30m);

            Console.WriteLine("Employee Salaries:");
            foreach (KeyValuePair<int, decimal> kvp in employeeSalaries)
            {
                Console.WriteLine($"Employee ID: {kvp.Key}, Salary: {kvp.Value:C}");
            }
        }
    }
}
