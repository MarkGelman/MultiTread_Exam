using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        /*
           Overdraft תשובה לשאילה: בכל פעם שמתרחש אירוע מסוג 
        */
        static Action<int> n;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount to withdraw:");
             int sum = Int32.Parse(Console.ReadLine());
             n = Overdraft;
            n.Invoke(sum);
            Console.ReadKey();
        }
        static void Overdraft (int sum)
        {
            if (5000 - sum <0)
            {
                if (n!=null)
                    
                        Console.WriteLine("OVERDRAFT!!!");
            }
            else
                Console.WriteLine("You in plus!!!");
        }
    }
}
