using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            MedicalService ms = new MedicalService();
            Thread t1 = new Thread(ms.DoctorTreatment);
            Thread t2 = new Thread(ms.DoctorTreatment);
            Thread t3 = new Thread(ms.DoctorTreatment);
            Thread t4 = new Thread(ms.DoctorTreatment);
            Thread t5 = new Thread(ms.DoctorTreatment);
            Thread t6 = new Thread(ms.DoctorTreatment);
            Thread t7 = new Thread(ms.DoctorTreatment);
            Thread t8 = new Thread(ms.DoctorTreatment);
            Thread t9 = new Thread(ms.DoctorTreatment);

            t1.Start();
            
            t2.Start();
            
            t3.Start();
           
            t4.Start();
           
            t5.Start();
          
            t6.Start();
            
            t7.Start();
            
            t8.Start();
           
            t9.Start();
           
        }
    }
}
