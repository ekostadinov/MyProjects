using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AlwaysCorrectData
{
    class GSM
    {
        public Battery Battery = new Battery();
        public Display Display = new Display();


        private string model  = "N70";
        private string owner = "No One";
        private string manufacturer = "Nokia Corp.";
        private decimal price = 1000.45m;

        public string PhoneModel
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string PhoneOwner
        {
            get { return this.owner; }
            private set { this.owner = value; }
        }

        public string PhoneManufacturer
        {
            get { return this.manufacturer; }
            private set { this.manufacturer = value; }
        }

        public decimal PhonePrice
        {
            get { return this.price; }
            private set { this.price = value; }
        }
       
    }
}
