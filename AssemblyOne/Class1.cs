using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        protected internal int ID = 101;
    }

    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine(A1.ID);
        }
    }
}
