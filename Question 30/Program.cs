using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item A' *****************************");
            Console.WriteLine();

            Console.WriteLine(" Task.WaitAny (t1, t2) - waits for some task in brackets to finish its work.\n\n After that, the main process will complete its work without waiting for the completion of the work of the rest of the running tasks.");


            Console.WriteLine();
            Console.WriteLine("*****************Answer to item B' *****************************");
            Console.WriteLine();

            Task t1 = Task.Run(() =>
            {

                Thread.Sleep(rnd.Next(5000,10000));
            });
            Task t2 = Task.Run(() =>
            {

                Thread.Sleep(rnd.Next(5000, 10000));
            });
            Task t3 = Task.Run(() =>
            {

                Thread.Sleep(rnd.Next(5000, 10000));
            });
            Task.WaitAny(t1, t2, t3);
            if (t1.IsCompleted) Console.WriteLine("t1 is done");
            if (t2.IsCompleted) Console.WriteLine("t2 is done");
            if (t3.IsCompleted) Console.WriteLine("t3 is done");

            Console.ReadKey();
        }
    }
}
