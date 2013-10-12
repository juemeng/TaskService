using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Castle.Windsor;

namespace TaskService.HostFactory
{
    public class CastleInstanceProvider : IInstanceProvider
    {
        public Type ServiceType { set; get; }
        private readonly IWindsorContainer _container;

        public CastleInstanceProvider(IWindsorContainer container)
        {
            _container = container;
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            var service = _container.Resolve(ServiceType.GetInterface("ITaskService"));
            return service;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }

    }
}