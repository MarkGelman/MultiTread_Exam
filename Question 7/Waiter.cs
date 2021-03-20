using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Waiter
    {
        internal void OneDishReady (object sender, DishEventArgs e)
        {
            Console.WriteLine($"Serving the {e.DishName} to the customers!");
        }
    }
}
