using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;

namespace _06.IPhone4S
{
    public class IApple
    {
        public static void Main()
        {
            GSM iPhone4SDevice = new GSM(null, null);

            iPhone4SDevice.Battery.HoursStandby = 10.5;
            iPhone4SDevice.Battery.HoursTalk = 3.5;
            iPhone4SDevice.Battery.Model = "IBatt4S";
            iPhone4SDevice.Battery.Type = GSMBatteryTypes.NiCd;

            iPhone4SDevice.PhoneManufacturer = "Apple Corp.";
            iPhone4SDevice.PhoneModel = "iPhone 4 S";
            iPhone4SDevice.PhoneOwner = "Apple fan";
            iPhone4SDevice.PhonePrice = 2000.50m;
                                    
        }
    }
}
