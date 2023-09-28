using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class PressureSensor_PlateSensor_
     {
          private bool verifyPlateSensor = false;


          protected bool VerifyPotPlate()
          {

               if (verifyPlateSensor == false)
               {
                    Console.Clear();
                    Console.WriteLine("Pot nu este setat!");
                    Console.WriteLine("Doriti sa setati Pot?");
                    Console.WriteLine("1. Da");
                    Console.WriteLine("2. Nu");
                    Console.Write("\nTastati: ");
                    string choicePot = Console.ReadLine();
                    Console.Clear();
                    if (choicePot == "1")
                         verifyPlateSensor = true;
                    else if (choicePot == "2")
                         verifyPlateSensor = false;
                    else
                         Console.WriteLine("Ati introdus date gresite!");


               }
               else
               {
                    Console.Clear();
                    Console.WriteLine("Pot este setat!");
                    Console.WriteLine("Doriti sa scoateti Pot?");
                    Console.WriteLine("1. Da");
                    Console.WriteLine("2. Nu");
                    Console.Write("\nTastati: ");
                    string choicePot = Console.ReadLine();
                    Console.Clear();
                    if (choicePot == "1")
                         verifyPlateSensor = false;
                    else if (choicePot == "2")
                         verifyPlateSensor = true;
                    else
                         Console.WriteLine("Ati introdus date gresite!");
               }
               return verifyPlateSensor;
          }


     }
}
