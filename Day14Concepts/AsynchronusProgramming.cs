using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14Concepts.AsynchronusProgramming
{
    public class AsynchronusProgrammingConcept
    {
        public static void Fun1()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Function1:" + i);   
            }
        }

        public static void Fun2()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Function2:" + i);
            }
        }

        public async static void Fun3()
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Function3:" + i);
            }
        }

        public async static void Fun4()
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Function4:" + i);
            }
        }

        public static void ThreadAndTaskExamples()
        {
            //Thread t1 = new Thread(new ThreadStart(AsynchronusProgrammingConcept.Fun1));
            Task t1 = new Task(AsynchronusProgrammingConcept.Fun1);

            //Thread t2 = new Thread(new ThreadStart(AsynchronusProgrammingConcept.Fun2));
            Task t2 = new Task(AsynchronusProgrammingConcept.Fun2);

            t1.Start();
            t2.Start();

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        public static void AsynchronousProgrammingExample()
        {
            Fun3();
            Fun4();

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
