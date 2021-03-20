using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t5 = new Task<int>(() =>
            {

                return 5+6;


            }, TaskCreationOptions.LongRunning);


            t5.Start();

            Console.WriteLine($"Result of task : {t5.Result}");
            Console.ReadKey();
        }
    }
}
