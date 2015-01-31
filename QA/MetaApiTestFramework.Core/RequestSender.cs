using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using MetaApiTestFramework.Core;

public class RequestSender
{
    public IMobileServiveRequest ObjMobileSerivceRequest = null;
    public IMailServiceRequest ObjMailServiceRequest = null;

    //injection through constructor  
    public RequestSender(IMobileServiveRequest tmpService)
    {
        ObjMobileSerivceRequest = tmpService;
    }
    //Injection through property  
    public IMailServiceRequest SetMailService
    {
        set { ObjMailServiceRequest = value; }
    }
    //We've reated a repository of all dependency types and build the repository.
    public void SendServiceRequest()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<SMSServiceRequest>().As<IMobileServiveRequest>();
        builder.RegisterType<EmailServiceRequest>().As<IMailServiceRequest>();
        var container = builder.Build();

        container.Resolve<IMobileServiveRequest>().Execute();
        container.Resolve<IMailServiceRequest>().Execute();
    }
}