using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.MobilePhoneDevice;

namespace _06.IPhone4S
{
    class IPhone
    {
        private GSM iGSM = new GSM(null, null);
                
        public GSM appleGSM
        {
            get { return this.iGSM; }
            set { this.iGSM = value; }
        }
        
    }
}
