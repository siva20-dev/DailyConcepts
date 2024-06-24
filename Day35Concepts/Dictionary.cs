using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.DictionaryConcepts
{
    public class Dictionary
    {
        public void DictionaryConceptsExamples1()
        {
            var months = new Dictionary<int, string>()
            {
                {1,"January" },
                {2,"February" },
                {3,"March" },
                {4,"April" },
                {5,"May" },
                {6,"June" }
            };

            months[7] = "July";
            months[8] = "August";
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "Decemeber");
            months[11] = "December";

            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            days["sun"] = "Sunday";
            days["mon"] = "Monday";

            days["Sun"] = "Tuesday";

            var sunday = days["sun"];

            var wednesday = days["wed"];

            var wednes = days.TryGetValue("wed", out string wed);

            foreach (var kvp in days)
            {
                Console.WriteLine($"key:{kvp.Key},value:{kvp.Value}");
            }

            days.Clear();

            if (days.ContainsKey("sun"))
            {
                days.Remove("sun");
            }

            foreach (var kvp in days)
            {
                Console.WriteLine($"key:{kvp.Key},value:{kvp.Value}");
            }
        }

        public void DictionaryExamples2()
        {
            Dictionary<int, string> studentNames = new Dictionary<int, string>();

            studentNames.Add(1, "Alice");
            studentNames.Add(2, "Bob");
            studentNames.Add(3, "Charlie");
            Console.WriteLine("Student Names:");

            foreach (KeyValuePair<int, string> kvp in studentNames)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }
        }

        public void DictionaryExamples3()
        {
            Dictionary<string, double> productPrices = new Dictionary<string, double>();

            productPrices.Add("Apple", 0.99);
            productPrices.Add("Banana", 0.59);
            productPrices.Add("Orange", 1.25);

            Console.WriteLine("\nProduct Prices:");
            foreach (KeyValuePair<string, double> kvp in productPrices)
            {
                Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value:C}");
            }
        }

        public void DictionaryExamples4()
        {
            Dictionary<Guid, DateTime> userRegistrationDates = new Dictionary<Guid, DateTime>();

            userRegistrationDates.Add(Guid.NewGuid(), DateTime.Now);
            userRegistrationDates.Add(Guid.NewGuid(), DateTime.Now.AddDays(-1));
            userRegistrationDates.Add(Guid.NewGuid(), DateTime.Now.AddDays(-2));

            Console.WriteLine("\nUser Registration Dates:");
            foreach (KeyValuePair<Guid, DateTime> kvp in userRegistrationDates)
            {
                Console.WriteLine($"User ID: {kvp.Key}, Registration Date: {kvp.Value}");
            }
        }
    }
}
