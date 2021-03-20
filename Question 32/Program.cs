using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item A' *****************************");
            Console.WriteLine();
            Console.WriteLine("Task stops working at all.\nThread.Suspend after Resum can resume its work again.");


            Console.WriteLine();
            Console.WriteLine("*****************Answer to item B' *****************************");
            Console.WriteLine();
            Console.WriteLine("You need to create an object of the class CancellationTokenSource tokenSourse = new CancellationTokenSource");
            Console.WriteLine("Task t5 = Task.Run(()=> {...},tokenSource.Token);");
            Console.ReadKey();
        }
    }
}
