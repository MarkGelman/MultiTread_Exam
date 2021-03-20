using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************Answer to item A' *****************************");
            Console.WriteLine();
            Console.WriteLine("ContinueWith -- allows  to run several tasks sequentially in one block RUN:");
            Console.WriteLine();
            Console.WriteLine("Task t1 = Task.Run<T>(() =>{return T}).ContinueWith((Task <T> antecendent) =>{....});");
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item B' *****************************");
            Console.WriteLine();
            Task t1 = Task.Run<int>(() =>  
                                        { 
                                            Console.WriteLine("Welcome!!!");
                                            return 5; 

                                        } ).ContinueWith((Task<int> antecendent) => 
                                          
                                        { 
                                            Console.WriteLine("Goodbye!!!");
                                        });
            t1.Wait();
            Console.WriteLine();
            Console.WriteLine("*****************Answer to item C' *****************************");
            Console.WriteLine();
            Console.WriteLine("Must be used as a parameter to the TASK constructor TaskContinuationOptions.OnlyOnFaulted");
            Console.WriteLine();
            Console.WriteLine("Task t1 = Task.Run<T>(() =>{return T;}).ContinueWith((Task <T> antecendent) =>{....},TaskContinuationOptions.OnlyOnFaulted);");
           

            Console.ReadKey();
        }
    }
}
