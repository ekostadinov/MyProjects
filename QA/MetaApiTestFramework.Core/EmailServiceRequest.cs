using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Core
{
    public class EmailServiceRequest : IMailServiceRequest
    {
        public void Execute()
        {
            Console.WriteLine("Email service Executing.");
        }
    }
}
