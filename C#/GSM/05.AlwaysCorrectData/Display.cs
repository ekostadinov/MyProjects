using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AlwaysCorrectData
{
    class Display
    {
        private int colors = 16000000;
        private double size = 4.3;

        public int Colors
        {
            get { return this.colors; }
            private set { this.colors = value; }
        }

        public double Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }
    }
}
