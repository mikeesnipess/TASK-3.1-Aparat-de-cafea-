using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class PressureReliefValue
     {

          protected int eNum(ref int count)
          {
               count++;
               if (count >= 5)
               {
                    Console.WriteLine("Presiunea a fost regulata!");
                    count = 0;
               }
               return count;
          }
     }

}
