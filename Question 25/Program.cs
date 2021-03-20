using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task t1 = new Task(() =>{},TaskCreationOptions.LongRunning");

            Task task1 = new Task(() => { Thread.Sleep(5000); Console.WriteLine(); Console.WriteLine("**********************"); Console.WriteLine(); Console.WriteLine($"Task B completed!!!"); }, TaskCreationOptions.LongRunning);
            task1.Start();
            task1.Wait();

            Console.ReadKey();
        }
    }
} 
