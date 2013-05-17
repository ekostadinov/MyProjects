using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MobilePhoneDevice
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private int? dialedPhoneNumber = null;
        private int duration;

        public Call(DateTime date, DateTime time, int? dialedPhoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return DateTime.Today; }
            private set { this.date = value; }
        }

        public DateTime Time
        {
            get { return DateTime.Now; }
            private set { this.time = value; }
        }

        public int? DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int CallDuration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

    }
}
