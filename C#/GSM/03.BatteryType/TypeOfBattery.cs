using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;

namespace _03.BatteryType
{
   public enum GSMBatteryTypes
    {  
      LiIon,
      NiMH,
      NiCd,
      BL5CT,
      BL4S
    }


    class TypeOfBattery
    {        
        static void Main()
        {    
            GSM myGSM = new GSM();
            myGSM.Battery.Type = GSMBatteryTypes.LiIon.ToString();
                        
            Console.WriteLine("The current battery of my GSM is: {0}" , myGSM.Battery.Type);
        }
        
    }
}
