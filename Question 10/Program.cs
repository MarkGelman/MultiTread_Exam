using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  RUNING -- is the state of the thread in which it is running. That is, the computer processor is busy executing\n" +
                "a function in this thread.\n" +
                "  ABORTED -- is a state of a thread in which its work has been terminated at all, regardless of whether the work of the function" +
                " in it has finished or not.\n" +
              "  SUSPEND is the state of a thread in which the work of the function in it is suspended.This thread returns to the RUN state only\n" +
                " after RESUME.");
            Console.ReadKey();
        }
    }
}
