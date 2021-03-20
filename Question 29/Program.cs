using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Run<int>(() =>
            {
                Console.WriteLine("Welcome!!!");
                return 5;
            }, TaskContinuationOptions.OnlyOnFaulted).ContinueWith((Task<int> antecendent) =>

            { Console.WriteLine("Goodbye!!!"); });
        }
    }
}
