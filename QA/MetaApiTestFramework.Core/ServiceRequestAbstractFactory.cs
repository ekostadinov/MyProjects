using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Core
{
    abstract class ServiceRequestAbstractFactory
    {
        public abstract IMailServiceRequest CreateEmailServiceRequest();
        //depending from the implementation it can be
        //public abstract IMobileServiveRequest CreateMobileServiveRequest();
    }
}
