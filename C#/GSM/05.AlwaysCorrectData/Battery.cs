using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AlwaysCorrectData
{
     public enum GSMBatteryTypes
    {  
      LiIon,
      NiMH,
      NiCd,
      BL5CT,
      BL4S
    }


    class Battery
    {
        private double hoursStandby = 36;
        private double hoursTalk = 10.5;
        private string model = "bat-12341444242";
        private string type;

        public Battery()
        {
        }

        public double HoursStandby
        {
            get { return this.hoursStandby; }
            private set { this.hoursStandby = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            private set { this.hoursTalk = value; }
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Type
        {
            get { return GSMBatteryTypes.NiMH.ToString(); }
            private set { this.type = value; }        
        }
       
    }
}
