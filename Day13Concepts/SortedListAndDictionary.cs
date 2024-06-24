using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.SortedListAndDictionary
{
    public class SortedListsAndDictionary
    {
        public static void SortedDictionaryExample()
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
    }
}
