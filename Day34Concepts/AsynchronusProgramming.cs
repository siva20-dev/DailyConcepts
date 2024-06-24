using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day34Concepts.AsynchronusProgramming
{
    public class AsynchronousProgrammingTopic
    {
        public void PrintNumbers1()
        {
            for (int number = 0; number < 10000; number++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("PrintNumbers1 - " + number);
            }
        }

        public void PrintNumbers2()
        {
            for (int number = 0; number < 10000; number++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("PrintNumbers2 - " + number);
            }
        }

        public async void PrintNumbers3()
        {
            for (int number = 0; number < 10000; number++)
            {
                await Task.Delay(1000);
                Console.WriteLine("PrintNumbers3 - " + number);
            }
        }

        public async void PrintNumbers4()
        {
            for (int number = 0; number < 10000; number++)
            {
                await Task.Delay(1000);
                Console.WriteLine("PrintNumbers4 - " + number);
            }
        }
    }
}
