using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            Thread singularThread1 = new Thread(() => { Console.WriteLine("Downloading file..."); Thread.Sleep(10000); Console.WriteLine("Completed!"); });
            singularThread1.Start();
            Thread singularThread2 = new Thread(() => Console.WriteLine($"{x} x {y} = {Multip(x,y)}"));
            singularThread2.Start();

            Console.ReadKey();
        }
        static int Multip(int x,int y)
            {
                return x*y;
            }
    }
}
