using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.CustomTypeAsADictionary
{
    public class CountryCode
    {
        public string Code { get; }

        public CountryCode(string code)
        {
            Code = code;
        }

        public static void CustomTypeAsADictionaryExample()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador()
            {
                CountryCode = new CountryCode("eng"),
                Name = "John",
                Age = 25
            };

            Ambassador australia = new Ambassador()
            {
                CountryCode = new CountryCode("aus"),
                Name = "Martin",
                Age = 49
            };

            ambassadors.Add(england.CountryCode, england);
            ambassadors.Add(australia.CountryCode, australia);

            Console.WriteLine("Enter Country Code");
            var code = Console.ReadLine();

            if (ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The Ambassador is {ambassador.Name}");
            }
            else
            {
                Console.WriteLine("The Ambassador with the given code doesn't exists");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is CountryCode))
            {
                return false;
            }

            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((CountryCode)obj).Code);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);
        }
    }

    public class Ambassador
    {
        public CountryCode CountryCode { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
    }
}
