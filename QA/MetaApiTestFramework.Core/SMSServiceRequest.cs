using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Core
{
    public class SMSServiceRequest : IMobileServiveRequest
    {
        public void Execute()
        {
            Console.WriteLine("SMS service executing.");
        }
    }
}
