using System.Web;
using Castle.DynamicProxy;

namespace TaskService
{
    public class WcfInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.Name != "CheckLogin")
            {
                if (HttpContext.Current.Session["UserName"] == null) 
                {
                    
                }
            }
            invocation.Proceed();
        }
    }
}