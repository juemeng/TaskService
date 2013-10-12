using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Castle.Windsor;

namespace TaskService.HostFactory
{
    public class CastleServiceBehavior : IServiceBehavior
    {
        public CastleInstanceProvider InstanceProvider { get; set; }

        private ServiceHost serviceHost;

        public CastleServiceBehavior(IWindsorContainer Castle)
        {
            InstanceProvider = new CastleInstanceProvider(Castle);
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (var cdb in serviceHostBase.ChannelDispatchers)
            {
                var cd = cdb as ChannelDispatcher;

                if (cd != null)
                {
                    foreach (var ed in cd.Endpoints)
                    {
                        InstanceProvider.ServiceType = serviceDescription.ServiceType;
                        ed.DispatchRuntime.InstanceProvider = InstanceProvider;
                    }
                }
            }
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {

        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            
        }

        public void AddToHost(ServiceHost host)
        {
            // only add to host once
            if (serviceHost != null) return;
            host.Description.Behaviors.Add(this);

            serviceHost = host;
        }
    }
}