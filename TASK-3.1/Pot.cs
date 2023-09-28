using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TASK_3._1
{
     class Pot : PlateHeater
     {
          private bool verifyPot = false;
          public bool AllVerify()
          {
               if( VerifyPotHeater() == true)
               {
                    verifyPot = true;
               }
               else
               {

                    verifyPot = false;
               }
               return verifyPot;
          }

          public bool potVerify()
          {
               return verifyPot;
          }
     }
}
