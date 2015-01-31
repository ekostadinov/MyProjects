using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Core
{
    abstract class ServiceRequestAbstractFactory
    {
        public abstract IServiceRequest CreateServiceRequest();
        //depending from the implementation the abstract methods may vary       
    }
}
