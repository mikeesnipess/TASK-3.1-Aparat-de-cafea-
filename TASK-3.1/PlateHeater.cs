using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class PlateHeater : PressureSensor_PlateSensor_
     {
          private bool plateHeater = false;

         
          protected bool VerifyPotHeater()
          {

               if (VerifyPotPlate() == true)
                    {
                    if (plateHeater == false)
                    {
                         Console.WriteLine("Doriti sa porniti Plate Heater?");
                         Console.WriteLine("1. Da");
                         Console.WriteLine("2. Nu");
                         Console.Write("\nTastati: ");
                         string choice = Console.ReadLine();
                         Console.Clear();
                         if (choice == "1")
                              plateHeater = true;
                         else if (choice == "2")
                              plateHeater = false;
                         else
                              Console.WriteLine("Ati introdus date gresite!");
                    }
                    else
                    {
                         Console.WriteLine("Plate Heater este pornit");
                         Console.WriteLine("Doriti sa-l stingeti?");
                         Console.WriteLine("1. Da");
                         Console.WriteLine("2. Nu");
                         Console.Write("\nTastati: ");
                         string choice = Console.ReadLine();
                         Console.Clear();
                         if (choice == "1")
                              plateHeater = false;
                         else if (choice == "2")
                              plateHeater = true;
                         else
                              Console.WriteLine("Ati introdus date gresite!");
                    }
               }
               else
               {
                    Console.WriteLine("Setati Pot!");
               }
               return plateHeater;
          }

     }
}
