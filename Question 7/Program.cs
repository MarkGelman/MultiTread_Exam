using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen k = new Kitchen();
            Waiter w = new Waiter();

            
            k.DishReady += w.OneDishReady;
            k.PrepareDish("shrimps");

            Console.ReadKey();

        }
    }
}
