using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {

                return DateTime.Now.Hour;
            })
           .ContinueWith(
               antecedent =>
               {
                   Console.WriteLine($"Now {antecedent.Result}H");
               }, TaskContinuationOptions.NotOnFaulted);
            Console.ReadKey();
        }
    }
}
