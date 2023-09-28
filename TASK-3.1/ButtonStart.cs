using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace TASK_3._1
{
     class ButtonStart
     {

          private bool verifyStatus;
         


          public bool TurnOn()
          {
               Regex regex = new Regex(@"^\w+$");
               Random random = new Random();
               string exit = null;
               do
               {
                    verifyStatus = random.Next(2) == 1;
                    if (verifyStatus == true)
                    {
                         Console.Clear();
                         Console.WriteLine("Aparatul a fost pornit cu succes!");
                    }
                    else
                    {

                         Console.WriteLine("Aparatul este deconectat de la energie...");
                         Console.WriteLine("Verifica conexiunea la energie!");
                         do
                         {
                              Console.WriteLine("Apasa butonul \"ENTER\" pentru a reporni din nou sau '0' pentru a lasa dispozitivul stins!");
                              Console.Write("Introdu: ");
                              exit = Console.ReadLine();
                              Console.WriteLine();

                              if (exit == "0")
                              {
                                   Console.Clear();
                                   Console.WriteLine("Have a nice day!");
                                   Environment.Exit(0);
                              }
                              else if (exit == "")
                              {
                                   continue;
                              }

                              else
                              {
                                   Console.Clear();
                                   Console.WriteLine("\nAti introdus date gresite!\n");
                              }
                         } while (regex.IsMatch(exit));


                    }
               }
               while (verifyStatus == false);

               return verifyStatus;
          }

          public bool TurnOff()
          {
               if (verifyStatus == false)
               {
                    Console.Clear();
                    Console.WriteLine("Aparatul este oprit!");
                    Console.WriteLine();
               }
               else
               {
                    Console.Clear();
                    Console.WriteLine("Ati oprit cu succes aparatul!");
                    verifyStatus = false;
                    Console.WriteLine();
               }
               return verifyStatus;
          }

     }
}
