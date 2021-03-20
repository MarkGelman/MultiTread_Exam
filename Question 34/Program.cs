using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 12, 42, 6, 15, 34, 82 };
            Workers w = new Workers();
            w.InitializationTasks(numbers);
        }
    }
}
