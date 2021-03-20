using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I would define this thread as FOREGROUND," +
                " since otherwise the main thread may finish its work before the last update of the state of shares on the burse is received.");
            Console.ReadKey();
        }
    }
}
