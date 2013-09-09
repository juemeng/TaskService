using Castle.Windsor;

namespace TaskService.HostBuilder
{
    public class Container
    {
        private static readonly object SyncRoot = new object();
        private static IWindsorContainer _instance;


        public static IWindsorContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
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
}