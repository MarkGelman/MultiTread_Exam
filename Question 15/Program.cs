using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A)  LOCK is used when a large number of threads must work simultaneously with the same function, collection, list, etc.,\n" +
                            " increasing the danger that different threads " +
                            "can simultaneously perform actions with this data, which can lead to an abnormal program termination ...");
            Console.WriteLine();
            Console.WriteLine("B)  CRITICAL SECTION is a part of a program in which two threads can simultaneously start working with the same data (function, collection, sheet, etc.).");
            Console.WriteLine();
            Console.WriteLine("C)  Monitor.Enter.... try-finally block and into this block Monitor.Exit");
            Console.WriteLine();
            Console.WriteLine("D)  YES! Lock can help!");
            Console.ReadKey();
        }
    }
}
