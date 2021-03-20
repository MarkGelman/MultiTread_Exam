using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_34
{
    class Workers
    {
        List<Task> tasks = new List<Task>();
        int index = 0;
       
       
        internal void InitializationTasks(List<int> numbers)
        {
            Random rnd = new Random();
            
            for (int i=0; i<5; i++)
            {
                index = rnd.Next(0, numbers.Count - 1);
                Task<int> t = Task.Run(() => numbers[index] * 2);
                tasks.Add(t);
            }
            Task.WaitAll(tasks.ToArray());
        }
        
    }
}
