using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputText)
        {
            if (inputText.Length > 0)
            {
                char[] names = inputText.ToCharArray();
                names[0] = char.IsUpper(names[0]) ? char.ToLower(names[0]) : char.ToUpper(names[0]);

                return new string(names);
            }

            return inputText;
        }
    }
}
