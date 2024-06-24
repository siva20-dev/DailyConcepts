using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.ComparingArrays
{
    public class ComparingArraysConcept
    {
        public void DaysofWeek()
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            string[] daysOfWeek2 = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            bool isSequenceEqual = daysOfWeek.SequenceEqual(daysOfWeek2);

            Console.WriteLine($"\n is SequenceEqual = {isSequenceEqual}");
        }
    }
}
