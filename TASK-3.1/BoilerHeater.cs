using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class BoilerHeater : WaterLevel
     {
          /// <summary>
          /// BoilerHeater
          /// </summary>
          public void VerifyBoiler()
          {
               
               Console.WriteLine("Procentul apei in boiler este de {0} %", GetProcentApa());

          }
     }
}
