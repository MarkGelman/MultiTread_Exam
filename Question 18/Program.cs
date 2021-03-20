using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" I believe it is best to use MONITOR.ENTER + MONITOR.EXIST and WAIT / PALSE\n"+
                                "THREADPOOL is not suitable for this task as it is intended for short - term tasks,\n"+
                                "and we cannot know how long it will take a doctor to examine a particular patient!!!");
           
            Console.ReadKey();
        }
    }
}
