using System;

namespace Day17Concepts.ExtensionMethods
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
