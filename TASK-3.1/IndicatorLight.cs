using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     class IndicatorLight : Filter_and_Receptacle
     {
          private decimal getFilter = 100;
          private decimal getReceptacle = 100;
          private bool boolReceptacle = true;
          private bool boolFilter = true;

          private decimal chargeFilter = 0;
          private string Filter()
          {
               string choice = null;
               if (verifyFilter(ref chargeFilter) == false)
               {
                    Console.WriteLine("\nFiltrul este epuizat!");
                    Console.WriteLine("Doriti sa-l resetati?");
                    Console.WriteLine("1. Da");
                    Console.WriteLine("2. Nu");
                    Console.Write("\nTastati: ");
                     choice = Console.ReadLine();
                    Console.Clear();
                    if (choice == "1")
                    {
                         Console.WriteLine("Filtrul a fost resetat cu succes!");
                         getFilter = 100;
                         chargeFilter = 100;
                         verifyFilter(ref chargeFilter);
                         
                    }
                    else
                    {
                         Console.WriteLine("Filtrul a ramas epuizat!");
                    }
               }
               else
               {
                    getFilter = chargeFilter;
                    chargeFilter = 0;
               }
               return choice;

          }


          private decimal chargeReceptacle = 100;
          private string Receptacle()
          {
               string choice = null;
               if (verifyReceptacle(ref chargeReceptacle) == false)
               {
                    Console.WriteLine("\nRecipientul s-a terminat!");
                    Console.WriteLine("Doriti sa puneti unul nou?");
                    Console.WriteLine("1. Da");
                    Console.WriteLine("2. Nu");
                    Console.Write("\nTastati: ");
                     choice = Console.ReadLine();
                    Console.Clear();
                    if (choice == "1")
                    {
                         Console.WriteLine("Recipientul a fost resetat cu succes!");
                         getReceptacle = 100;
                         chargeReceptacle = 100;
                         verifyReceptacle(ref chargeReceptacle);

                    }
                    else
                    {
                         Console.WriteLine("Nu este Recipient!");
                    }
               }
               else
               {
                    getReceptacle = chargeReceptacle;
                    chargeReceptacle = 0;
               }
               return choice;
          }


          
          public void GetReceptacleFilter()
          {
               
               
                   Console.WriteLine("Starea filtrului este de ─ {0} %", getFilter);



                    Console.WriteLine("A mai ramas recipient ─ {0} %", getReceptacle);
               
          }

          public bool VerifyReceptacleFilter()
          {
               if (getFilter < 13.22m)
               {
                    Console.WriteLine("\nVerificati indicatoarele luminiscente!\n");
                    boolFilter = false;

               }
               else
               {
                    Filter();
                    boolFilter = true;
               }


               if (getReceptacle < 7.32m)
               {
                    Console.WriteLine("Verificati indicatoarele luminiscente!!");
                    boolReceptacle = false;
               }
               else
               {
                    Receptacle();
                    boolReceptacle = true;
               }

               return boolReceptacle && boolFilter ; 
          }

          public void ReloadReceptacleFilter()
          {
               if(getFilter <15)
               {
                    Filter();
               }

               if(getReceptacle < 7.32m)
               {
                    Receptacle();
               }
          }
     }
}
