using Castle.Windsor;

namespace TaskService.HostFactory
{
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
}