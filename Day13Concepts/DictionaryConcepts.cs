using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.DictionaryConcepts
{
    public class DictionaryConceptExample
    {
        public static void DictionaryConceptsExamples1()
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
    }
}
