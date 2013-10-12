using System;
using System.Web.Routing;
using System.ServiceModel.Activation;
using Castle.MicroKernel.Registration;
using TaskService.DAL;
using TaskService.HostFactory;
using TaskService.Repository;
using Castle.Core;

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
                Component.For<ITaskService>().ImplementedBy<TaskService>().LifestylePerWebRequest()
                .Interceptors(InterceptorReference.ForType<WcfInterceptor>()).Anywhere,

                Component.For<WcfInterceptor>());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            // 默认页
            routes.Add(new ServiceRoute("", new CastleServiceHostFactory(), typeof(TaskService)));
        }
    }
}