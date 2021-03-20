using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("At some time, we decided that it was very difficult to work with threads because of their very limited functionality.\n" +
                               "Then  decided to create the TASK LIBRARY, which makes it easy to work with threads.\n" +
                                "Their functionality includes(advantages of TASK over THREAD):\n" +
                                "1. Returning a response from a thread\n" +
                                "2. Stop the work of one thread and at the same time give the command to the other thread to start working\n" +
                                "3. Inheriting threads from the main stream\n" +
                                "4. Allow the thread to wait until a certain number of threads (1,2,4,13 ....) from the total number of those in operation finish work.\n" +
                                "5. Using ASYNC process");
            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine();
            Console.WriteLine(" .NET Framework 4");
            Console.ReadKey();
        }
    }
}
