using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.ExtensionMethods
{
    public class ExtensionMethod
    {
        public void ExtensionMethodsExample()
        {
            string name = "pragim";
            string result = name.ChangeFirstLetterCase();
            //string result = StringHelper.ChangeFirstLetterCase(name);

            Console.Write(result);
        }
    }
}
