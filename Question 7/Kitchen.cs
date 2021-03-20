using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Kitchen
    {
        public event EventHandler<DishEventArgs> DishReady;
        internal void PrepareDish (string dishName)
        {
            Console.WriteLine("Preparing dish...");
            OnDishReady(dishName );
        }

        void OnDishReady (string dishName)
        {
            if (DishReady != null)
                DishReady.Invoke(this, new DishEventArgs { DishName = dishName });

        }
    }
}
