using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_12
{
    class Program
    {
        static int num ;
        static void Main(string[] args)
        { 
            Thread t = new Thread(() => Console.WriteLine("Hello World"));
            t.Start();
            t.Join();
            Console.Write("Please enter number: ");
            num =  Int32.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(  );
            numbers.Add(1);
            numbers.Add(12);
            numbers.Add(103);
            numbers.Add(24);
            numbers.Add(57);
            numbers.Add(69);
            numbers.Add(73);

            Thread t2 = new Thread((x) => 
                                          {
                                             
                                              if (numbers.Contains((int)x)) 
                                                Console.WriteLine("Exist"); 
                                            else 
                                                Console.WriteLine("No exist!!!"); 
                                          } 
                                   );
            t2.Start(num);
            Console.ReadKey();
        
        }
    }
}
