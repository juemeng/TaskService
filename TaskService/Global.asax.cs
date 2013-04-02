using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.ServiceModel.Activation;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using TaskService.DAL;
using TaskService.Repository;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using Castle.Core;
using Castle.DynamicProxy;

namespace TaskService
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);


            Container.Instance.Register(Component.For<ITaskRepository>().ImplementedBy<TaskRepository>(),
                Component.For<IUserRepository>().ImplementedBy<UserRepository>(),
                Component.For<TaskEntities>().ImplementedBy<TaskEntities>(),
                Component.For<ITaskService>().ImplementedBy<TaskService>()
                .Interceptors(InterceptorReference.ForType<WcfInterceptor>()).Anywhere,

                Component.For<WcfInterceptor>());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            // 默认页
            routes.Add(new ServiceRoute("MService", new CastleServiceHostFactory(), typeof(TaskService)));
        }
    }

    #region CastleServiceHostFactory
    public class CastleServiceHostFactory : WebServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            CastleServiceHost host = new CastleServiceHost(serviceType, Container.Instance, baseAddresses);

            return host;
        }
    }

    public class CastleServiceHost : WebServiceHost
    {
        IWindsorContainer _container;

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

    public class CastleServiceBehavior : IServiceBehavior
    {
        public CastleInstanceProvider InstanceProvider
        {
            get;
            set;
        }

        private System.ServiceModel.ServiceHost serviceHost = null;

        public CastleServiceBehavior(IWindsorContainer Castle)
        {
            InstanceProvider = new CastleInstanceProvider(Castle);
        }

        public void ApplyDispatchBehavior(
          ServiceDescription serviceDescription,
          ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcherBase cdb
                 in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher cd = cdb as ChannelDispatcher;

                if (cd != null)
                {
                    foreach (EndpointDispatcher ed
                                    in cd.Endpoints)
                    {
                        InstanceProvider.ServiceType
                             = serviceDescription.ServiceType;
                        ed.DispatchRuntime.InstanceProvider
                             = InstanceProvider;

                    }
                }
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

        public void AddToHost(System.ServiceModel.ServiceHost host)
        {
            // only add to host once
            if (serviceHost != null) return;
            host.Description.Behaviors.Add(this);

            serviceHost = host;
        }
    }

    public class CastleInstanceProvider : IInstanceProvider
    {
        public Type ServiceType { set; get; }
        private IWindsorContainer _container;

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

    public class Container
    {
        private static readonly object _syncRoot = new object();
        private static IWindsorContainer _instance;


        public static IWindsorContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new WindsorContainer();
                        }
                    }
                }
                return _instance;
            }
        }
    }
    #endregion

    public class WcfInterceptor : Castle.DynamicProxy.IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.Name != "CheckLogin")
            {
                if (HttpContext.Current.Session["UserName"] == null) 
                {
                    string name = "a";
                }
            }
            invocation.Proceed();
        }
    }
}