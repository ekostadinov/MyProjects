using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MobilePhoneDevice
{
    public enum GSMBatteryTypes
    {
        LiIon,
        NiMH,
        NiCd,
        BL5CT,
        BL4S
    }

    public class Battery //it is public because i use this class in my 3th project
    {
        private double? hoursStandby = null;
        private double? hoursTalk = null;
        private string model = null;
        private Enum type;
   
        public double? HoursStandby
        {
            get { return this.hoursStandby; }
            set { this.hoursStandby = value; }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Enum Type
        {
            get { return GSMBatteryTypes.LiIon; }
            set { this.type = value;}
        }

        public Battery()
        {
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double hoursStandby)
            : this(model)
        {
            this.HoursStandby = hoursStandby;
        }

        public Battery(string model, double hoursStandby, double hoursTalk)
            : this(model, hoursStandby)
        {
            this.HoursTalk = hoursTalk;
        }

       
    
    }
}
