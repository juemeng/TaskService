using System;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace TaskService.HostFactory
{
    public class CastleServiceHostFactory : WebServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            var host = new CastleServiceHost(serviceType, Container.Instance, baseAddresses);

            return host;
        }
    }
}