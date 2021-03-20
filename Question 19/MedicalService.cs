using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_19
{
    class MedicalService
    {
        string door = "open";
        private object keyDoctor = new object();
        //private object keyNurse = new object();

        public void DoctorTreatment ()
        {
            lock (keyDoctor)
            {
                while (door == "close")
                {
                    Console.WriteLine("Waiting for my turn");
                    Monitor.Wait(keyDoctor);
                }
                door = "close";
            }
            Console.WriteLine("Getting treatment!");
            NurseCheck();
        }

        private void NurseCheck()
        {
           
                lock (keyDoctor)
                {
                    Console.WriteLine("Nurse is checking");
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Next patient please");
                door = "open";
                Monitor.Pulse(keyDoctor);
        }
           
        
    }
}
