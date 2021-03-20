using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item A' *****************************");
            Console.WriteLine();
            Console.WriteLine("Task.WaitAll (task1, task2...) - waits for all tasks in brackets to finish its work ");

            Console.WriteLine();
            Console.WriteLine("*****************Answer to item B' *****************************");
            Console.WriteLine();

            Task t1 = Task.Run(() =>
            {

                Thread.Sleep(5000);
            });
            Task t2 = Task.Run(() =>
            {

                Thread.Sleep(5000);
            });
            Task t3 = Task.Run(() =>
            {

                Thread.Sleep(5000);
            });
            Task.WaitAll(t1, t2, t3);
            if (t1.IsCompleted) Console.WriteLine("t1 Completed");
            if (t2.IsCompleted) Console.WriteLine("t2 Completed");
            if (t3.IsCompleted) Console.WriteLine("t3 Completed");
         

            Console.WriteLine();
            Console.WriteLine("*****************Answer to item C' *****************************");
            Console.WriteLine();

            Console.WriteLine("Correct code:\n  While (!t.IsCompleted)\n {\n   Thread.Yield;\n }\n  You should always write a delay in the body of such a loop.Without this line, processor overload is possible.");
            Console.ReadKey();
        }
    }
}
