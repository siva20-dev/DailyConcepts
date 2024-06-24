using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.DebugVSReleaseMode
{
    public class DebugVSReleaseModeTopic
    {
        public void Method1()
        {
            Method2();
        }

        public  void Method2()
        {
            Method3();
        }

        public void Method3()
        {
            throw new Exception("Some Error");
        }

        public void DebugVSReleaseModeExample()
        {
#if DEBUG
            Console.WriteLine(DateTime.Now);
#endif            
            Console.WriteLine("Hello");
        }
    }
}
