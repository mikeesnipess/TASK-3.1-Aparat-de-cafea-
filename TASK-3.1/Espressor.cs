using System;
using System.Threading;

namespace TASK_3._1
{
     class Espressor
     {
          static void Main()
          {

               bool OnOFf = false;
               decimal WaterLevel = 0;

               IndicatorLight indicator = new IndicatorLight();
               Boiler boiler = new Boiler();
               Pot pot = new Pot();

               do
               {
                    Console.WriteLine();
                    Console.WriteLine("1. Porneste aparatul");
                    Console.WriteLine("2. Pune/scoate Pot | On/Off PlateHeater");
                    Console.WriteLine("3. Verifica indicatoarele luminiscente");
                    Console.WriteLine("4. Fa-mi un espresso!");
                    Console.WriteLine("\n0.Stinge aparatul!");
                    Console.WriteLine("00.Deconectare full!");
                    Console.WriteLine();
                    Console.Write("Apasa: ");
                    string choice = Console.ReadLine();
                    Console.Clear();

                    switch (choice)
                    {
                         case "1":
                              {
                                   if (OnOFf == true)
                                   {
                                        Console.WriteLine("Aparatul este pornit!");
                                   }
                                   else
                                   {
                                        ButtonStart TurnOnOff = new ButtonStart();
                                        OnOFf = TurnOnOff.TurnOn();
                                        Console.WriteLine();
                                   }
                              }
                              break;
                         case "2":
                              {
                                   pot.AllVerify();



                              }
                              break;
                         case "3":
                              {

                                   if (OnOFf == false)
                                   {
                                        Console.Clear();
                                        Console.WriteLine("Porneste aparatul!");
                                        Console.WriteLine();
                                        break;
                                   }
                                   else
                                   {

                                        boiler.VerifyBoiler(ref WaterLevel);
                                        boiler.VerifyBoiler();
                                        indicator.GetReceptacleFilter();
                                        indicator.ReloadReceptacleFilter();


                                   }

                              }
                              break;

                         case "4":
                              {
                                   if (OnOFf == false)
                                   {
                                        Console.Clear();
                                        Console.WriteLine("Porneste aparatul!");
                                        Console.WriteLine();
                                        break;
                                   }
                                   else if (pot.potVerify() == false)
                                   {

                                        Console.Clear();
                                        Console.WriteLine("Setati Pot!");
                                        Console.WriteLine("Porniti PotHeater!");
                                        Console.WriteLine();
                                        break;


                                   }
                                   else if (WaterLevel <= 10)
                                   {
                                        Console.WriteLine("\nBoilerul este gol!");
                                        Console.WriteLine("Verificati indicatoarele luminiscente!");
                                        Console.WriteLine();
                                        break;
                                   }
                                   else if (indicator.VerifyReceptacleFilter() == false) { break; }
                                   else
                                   {
                                        Console.Clear();
                                        Console.WriteLine("Se pregateste Espresso!");
                                        Thread.Sleep(1000);
                                        for (int i = 0; i < 3; i++)
                                        {
                                             Console.Clear();
                                             Console.WriteLine("Loading... ─");
                                             Thread.Sleep(20);
                                             Console.Clear();
                                             Console.WriteLine("Loading... \\");
                                             Thread.Sleep(20);
                                             Console.Clear();
                                             Console.WriteLine("Loading... |");
                                             Thread.Sleep(20);
                                             Console.Clear();
                                             Console.WriteLine("Loading... /");
                                             Thread.Sleep(20);
                                             Console.Clear();
                                             Console.WriteLine("Loading... ─");
                                             Thread.Sleep(20);
                                             Console.Clear();

                                        }
                                        WaterLevel -= 5.27m;
                                        Console.WriteLine("Espresso este gata!");
                                   }
                              }
                              break;
                         case "0":
                              {
                                   ButtonStart TurnOnOff = new ButtonStart();
                                   OnOFf = TurnOnOff.TurnOff();
                              }
                              break;
                         case "00":
                              {
                                   Console.Clear();
                                   Console.WriteLine("Have a nice day!");
                                   Environment.Exit(0);

                              }
                              break;

                         default:
                              {
                                   Console.WriteLine("Ati introdus numar gresit!");
                              }
                              break;

                    }
               } while (true);
          }

     }
}