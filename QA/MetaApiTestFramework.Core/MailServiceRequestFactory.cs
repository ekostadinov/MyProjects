using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Core
{
    class MailServiceRequestFactory : ServiceRequestAbstractFactory
    {
        public override IMailServiceRequest CreateEmailServiceRequest()
        {
            return new EmailServiceRequest();
        }
    }
}
