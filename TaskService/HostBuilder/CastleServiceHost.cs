using System;
using System.ServiceModel.Web;
using Castle.Windsor;

namespace TaskService.HostBuilder
{
    public class CastleServiceHost : WebServiceHost
    {
        readonly IWindsorContainer _container;

        public CastleServiceHost(
            Type serviceType,
            IWindsorContainer container,
            params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            _container = container;
        }

        protected override void OnOpening()
        {
            new CastleServiceBehavior(_container).AddToHost(this);

            base.OnOpening();
        }
    }
}