using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MobilePhoneDevice
{
    class Display
    {
        private int colors;
        private double size;

        public int Colors {
            get { return this.colors;}
            set { this.colors = value; }
        }

        public double Size {
            get { return this.size; }
            set { this.size = value;}
        }


    }
}
