using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Castle.Windsor;

namespace TaskService
{
    public class CastleServiceBehavior : IServiceBehavior
    {
        public CastleInstanceProvider InstanceProvider
        {
            get;
            set;
        }

        private ServiceHost _serviceHost;

        public CastleServiceBehavior(IWindsorContainer castle)
        {
            InstanceProvider = new CastleInstanceProvider(castle);
        }

        public void ApplyDispatchBehavior(
            ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase)
        {
            foreach (EndpointDispatcher ed in serviceHostBase.ChannelDispatchers.OfType<ChannelDispatcher>().SelectMany(cd => cd.Endpoints))
            {
                InstanceProvider.ServiceType
                    = serviceDescription.ServiceType;
                ed.DispatchRuntime.InstanceProvider
                    = InstanceProvider;
            }
        }

        public void AddBindingParameters(
            ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase,
            Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
        }

        public void Validate(
            ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase) { }

        public void AddToHost(ServiceHost host)
        {
            // only add to host once
            if (_serviceHost != null) return;
            host.Description.Behaviors.Add(this);

            _serviceHost = host;
        }
    }
}