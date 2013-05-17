using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MobilePhoneDevice
{
    class CommonInfo
    {
        static void Main()
        {
            GSM test = new GSM();

            test.Battery.Model = "Samsung 123";
            test.Display.Size = 6.5;
            test.PhoneManufacturer = "Samsung Corp.";

            Console.WriteLine("battery model: {0} \n display size: {1} \n phone manufacturer: {2}", test.Battery.Model, test.Display.Size, test.PhoneManufacturer);
        }
    }
}
