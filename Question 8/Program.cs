using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You need to use multithread in the second case, because in this case, we receive requests from several users at the same time, which makes it very difficult to execute the program if we do not use multitread."+
                                "In the first case, only one user sends the request, which is unlikely to cause interruptions in the program execution.");
        }
    }
}
