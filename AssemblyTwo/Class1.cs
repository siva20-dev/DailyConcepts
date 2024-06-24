using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            base.ID = 101;

            //or

            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.ID = 102;
        }
    }
}
