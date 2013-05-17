using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MobilePhoneDevice
{
    class Battery
    {
        private double hoursStandby;
        private double hoursTalk;
        private string model;

        public double HoursStandby {
            get{ return this.hoursStandby;}
            set { this.hoursStandby = value; }        
        }

        public double  HoursTalk{
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}
