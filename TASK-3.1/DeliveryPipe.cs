using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
    abstract class DeliveryPipe : PressureReliefValue
     {
          private bool pipeDeliver = false;
          public bool deliveryPipe(int procente)
          {
               if(procente!=0)
               {
                    pipeDeliver = true;
               }
               else
               {
                    Console.WriteLine("Nu este apa in boiler!");
               }

               return pipeDeliver;
          }

          
     }
}
