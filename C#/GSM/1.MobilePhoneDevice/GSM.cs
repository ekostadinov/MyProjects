using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.MobilePhoneDevice
{
    class GSM
    {
        private string model;
        private string owner;
        private string manufacturer;
        private decimal price;

        public string PhoneModel {
            get { return this.model; }
            set { this.model = value; }
        }

        public string PhoneOwner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string PhoneManufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal PhonePrice
        {
            get { return this.price; }
            set { this.price = value; }
        }


        //public GSM (string model, string manufacturer, string owner, decimal price)
        //{
        //    model = "Samsung 1";
        //    manufacturer = "Samsung Corp.";
        //    owner = "NoOne";
        //    price = 123.45m;
        //}

        public Battery Battery = new Battery();
        public Display Display = new Display();
        
    }
}
