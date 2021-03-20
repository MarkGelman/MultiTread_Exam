using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_9
{
    class Program
    {
        static Stopwatch sw = new Stopwatch();
        static Stopwatch sw1 = new Stopwatch();
        //static long countTime;
        static void Main(string[] args)
        {
            List<Thread> t = new List<Thread>();
            sw.Start();
            LongOperation();
            LongOperation();
            LongOperation();
            LongOperation();
            LongOperation();
            long ticks = sw.ElapsedMilliseconds;
            Console.WriteLine($"Sequential run time = {ticks}");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();
  
            sw.Reset();
            sw.Start();
            Thread t1 =  new Thread(LongOperation);
            t1.Start();
            Thread t2 = new Thread(LongOperation);
            t2.Start();
            Thread t3 = new Thread(LongOperation);
            t3.Start();
            Thread t4 = new Thread(LongOperation);
            t4.Start();
            Thread t5 = new Thread(LongOperation);
            t5.Start();
                
     
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            ticks = sw.ElapsedMilliseconds;
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"Parallel time (threads) = {ticks}\n");

            Console.WriteLine("Result:\n"+
                                "  Almost 3 times faster.\n  In my opinion, this happened as a result of the simultaneous parallel operation\n " +
                                "of 5 threads at once.That is, no one waited for one threadto complete its work in order for the second to\n " +
                                "start(as in the first case).The start of work of 5 threads happened almost simultaneously, which made it possible\n" +
                                " to finish the program almost 3 times faster than in the first case !!!") ;
        
                    
            Console.ReadKey();
        }
        static void LongOperation()
        {
            for(int i=0;i<1000000000;i++)
            {

            }
            Console.WriteLine("Done!!!");
        }
    }
}
