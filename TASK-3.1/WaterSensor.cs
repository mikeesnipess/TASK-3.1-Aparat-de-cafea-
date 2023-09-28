using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class WaterSensor 
     {
          /// <summary>
          /// WaterSensorBoiler
          /// </summary>
          /// <param name="setWaterSensor"></param>
          public void VerifyBoiler(bool setWaterSensor)
          {
               if(setWaterSensor == true)
               {
                    Console.WriteLine("Apa este in boiler!");
               }
               else
               {
                    Console.WriteLine("Apa nu este in boiler!");
               }
          }
     }
}
