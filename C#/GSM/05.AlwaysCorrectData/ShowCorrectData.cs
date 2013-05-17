using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AlwaysCorrectData
{
    class ShowCorrectData
    {
        static void Main()
        {
            GSM myGSM = new GSM();

            Console.WriteLine("Main info:");
            Console.WriteLine("Phone Manufacturer - {0}", myGSM.PhoneManufacturer);
            Console.WriteLine("Phone Model - {0}", myGSM.PhoneModel);
            Console.WriteLine("Phone Owner - {0}", myGSM.PhoneOwner);
            Console.WriteLine("Phone Price - {0}", myGSM.PhonePrice);
            Console.WriteLine("Display Colors - {0}", myGSM.Display.Colors);
            Console.WriteLine("Display Size - {0}", myGSM.Display.Size);
            Console.WriteLine("Battery Type - {0}", myGSM.Battery.Type);
            Console.WriteLine("Battery Model - {0}", myGSM.Battery.Model);
            Console.WriteLine("Hours on standby - {0}", myGSM.Battery.HoursStandby);
            Console.WriteLine("Hours talk - {0}", myGSM.Battery.HoursTalk);

            //compile-time error
            //myGSM.PhoneManufacturer = "Samsung";
        
        
        }
    }
}
