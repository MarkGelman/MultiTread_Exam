using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_33
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSourse = new CancellationTokenSource();
            Console.WriteLine("Timer is starting");
            Task t = Task.Run(() =>
                                    {
                                        while (true && !tokenSourse.IsCancellationRequested)
                                        {
                                            Thread.Sleep(1000);
                                            MyTimer();
                                        }
                                    });
            
            
            Console.ReadLine();
            tokenSourse.Cancel();
            Console.WriteLine($"Timer is stopped:{count}");
        }
        static void MyTimer()
        {
                count++;
        }
    }
}
