using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item A' *****************************");
            Console.WriteLine();
            Console.WriteLine("The code did not collapse!!!");

            Console.WriteLine();
            Console.WriteLine("*****************Answer to item B' *****************************");
            Console.WriteLine();
            Console.WriteLine("The program collapsed with an explanation of why!!!");

            Console.WriteLine();
            Console.WriteLine("*****************Answer to item C' *****************************");
            Console.WriteLine();
            Task <int> t3 = Task.Factory.StartNew<int>(() =>
            {
                Thread.Sleep(100);
                int a = 0;
                int b = 1 / a;
                return b;
               
            },TaskCreationOptions.LongRunning);

            if(t3.IsFaulted)
            {
                t3.Exception.Handle(e =>
                {
                    Console.WriteLine("Cannot divide by zero!!!");
                    return true;
                });
            }
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item D' *****************************");
            Console.WriteLine();
            Console.WriteLine("  AggregateException");
            Console.ReadKey();
        }
    }
}
