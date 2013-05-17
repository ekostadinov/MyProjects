using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BatteryType
{
    class Battery
    {      
        private string model;
        private string type;
        
        
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        
    }
}
