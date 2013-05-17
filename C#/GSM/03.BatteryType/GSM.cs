using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BatteryType
{
    class GSM
    {
        public Battery Battery = new Battery();
                
        private string model;
        private string owner;
       

        public string PhoneModel
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string PhoneOwner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

    }
}
