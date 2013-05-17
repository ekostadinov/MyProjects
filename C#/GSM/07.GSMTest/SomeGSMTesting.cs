using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;
using _06.IPhone4S;


namespace _07.GSMTest
{   
    class SomeGSMTesting
    {        
        static void Main()
        {
            GSM[] gsmArr = new GSM[3];
            string[] gsmModelArr = { "N90","5800","N70"};
            string[] gsmManufacturerArr = { "Nokia","HTC","Samsung"};
            decimal[] gsmPriceArr = { 1000m, 200.34m, 2000.3434m};
            string[] gsmOwnerArr = { "IBot","IDummy","IWorm"};

            for (int i = 0; i < gsmArr.Length; i++)
            {
                gsmArr[i] = new GSM(gsmModelArr[i], gsmManufacturerArr[i], gsmPriceArr[i], gsmOwnerArr[i]);
                
                Console.WriteLine("Override ToString(): ");
                Console.WriteLine(gsmArr[i].ToString());
                Console.WriteLine(gsmModelArr[i]);
                Console.WriteLine(gsmManufacturerArr[i]);
                Console.WriteLine(gsmPriceArr[i]);
                Console.WriteLine(gsmOwnerArr[i]);                
            }

            GSM iphone = new GSM(null,null);
            iphone.iPhone4s.PhoneManufacturer = "Apple Corp.";
            iphone.iPhone4s.PhoneModel = "iPhone 4 S";

            Console.WriteLine(iphone.iPhone4s.PhoneManufacturer);
            Console.WriteLine(iphone.iPhone4s.PhoneModel);
            
        }
    }
}
