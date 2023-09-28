using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_3._1
{
     abstract class Filter_and_Receptacle : DeliveryPipe
     {
          private int count = 0;
          private decimal countFilter = 100;

          private bool filter = true;
          protected bool verifyFilter(ref decimal charge)
          {
               if (countFilter < 15)
               {
                    filter = false;
               }
               else
               {
                    filter = true;
                    countFilter -= 7.89m;
                    charge = countFilter;
               }

               if (charge == 100)
               {
                    countFilter = charge;
               }

               eNum(ref count);

               return filter;
          }



          private bool receptacle = true;
          private decimal countReceptacle = 100;
          protected bool verifyReceptacle(ref decimal charge)
          {
               if (countReceptacle < 15)
               {
                    receptacle = false;
               }
               else
               {
                    receptacle = true;
                    countReceptacle -= 13.28m;
                    charge = countReceptacle;
               }
               if(charge == 100)
               {
                    countReceptacle = charge;
               }

               return receptacle;
          }
     }

}







