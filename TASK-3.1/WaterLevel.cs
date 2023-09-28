using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class WaterLevel : WaterSensor
     {

          private decimal procenteApa = 0;
          /// <summary>
          /// WaterLEVEL
          /// </summary>
          public decimal VerifyBoiler(ref decimal procente)
          {
               string alege = null;
               if (procente <= 10)
               {
                    Console.WriteLine("Adaugati apa in boiler!");
                    Console.WriteLine("1. 100%");
                    Console.WriteLine("2. 50%");
                    Console.WriteLine("3. 25%");
                    Console.Write("\nTastati: ");
                    alege = Console.ReadLine();
                    Console.Clear();
                    if (alege == "1")
                         procente = 100;
                    else if (alege == "2")
                         procente = 50;
                    else if (alege == "3")
                         procente = 25;
                    else
                    {
                         Console.WriteLine("Ati introdus date gresite!");
                    }

                    

               }
               else
               {
                    Console.WriteLine("Apa in boiler a fost adaugata {0} %",procente);
                    
               }
               this.procenteApa = procente;

               return procente;
          }

          public decimal GetProcentApa()
          {
               return procenteApa;
          }
     }
}
