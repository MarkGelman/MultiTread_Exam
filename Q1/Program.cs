using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{

    class Program
    {
        public delegate double F1 (double x, double y);// Question 3
        static F1 add;// Question 3
        static void Main(string[] args)
        {

            //Question 1
            
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i=0; i<100; i++)
            {
                numbers.Add(rnd.Next(0, 50));
            }
//'א
            List<int> less10 = numbers.Where(_ => _ < 10).ToList();
            PrintAll<int>(less10, "A");
//'ב
            List<int> div3 = numbers.Where(_ => _ %3 == 0).ToList();
            PrintAll<int>(div3,"B");
//'ג
            List<int> more20 = numbers.Where(_ => _ >20 && _%2 == 0).ToList();
            PrintAll<int>(more20,"C");
//'ד
            List<int> fromHigherToLower = numbers.OrderByDescending(_=>_).ToList();
            PrintAll<int>(fromHigherToLower,"D");

            //*******************************************************************  Question № 2 ************************************************************************/
            Console.WriteLine();
            Console.WriteLine("****************************************** Question 2 *********************************************************");
            List<string> names = new List<string>()
            { "John","Ichak","Donald","Michail","Daniel","Shmuel","Beniamin","Moshe","Franklin","Nikita" };
            List<string> test = new List<string>();
            test = names.Where(_ => _.Length > 4).ToList();
            PrintAll(test, "A");
            names.ForEach(_ => { if (_.Contains("a")) { Console.WriteLine($"{_}"); } Console.WriteLine("********"); });
            test = names.OrderBy(_ => _).ToList();
            PrintAll(test, "C");
            Console.ReadKey();

            //*******************************************************************  Question № 3 ************************************************************************/
            
            Console.WriteLine();
            Console.WriteLine("****************************************** Question 3 *********************************************************");
            add = Add;
            Console.WriteLine( $"{add.Invoke(1, 2)}"); 

            //*******************************************************************  Question № 4 ************************************************************************/
            Console.WriteLine();
            Console.WriteLine("****************************************** Question № 4 *********************************************************");
            Console.WriteLine();
            Console.WriteLine("Section A: Func\n Section B: Action");

            Console.ReadKey();
        }


        
        static double Add (double x, double y)
        {
            return x + y;
        }
        
        public static void PrintAll<T>(List<T> numbersList, string numQuestion)
        {
            Console.WriteLine($"{numQuestion}");
            Console.WriteLine();
            foreach (T number in numbersList)
                Console.WriteLine($"{ number}");   
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    }
}
