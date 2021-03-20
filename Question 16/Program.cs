using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" System.Collection.Concurrent.ConcurrentDictionary<int,int> dict = new  System.Collection.Concurrent.ConcurrentDictionary<int,int>();");
            Console.WriteLine();
            Console.WriteLine("The advantage is that there is no danger that you will forget to put LOCK somewhere or assign the key to it incorrectly.\n"+
                              "The disadvantage is that it takes more resources from the program than writing LOCK 'manually'.");
            Console.ReadKey();
        }
    }
}
