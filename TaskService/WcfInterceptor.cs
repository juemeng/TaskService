using System.Web;
using Castle.DynamicProxy;

namespace TaskService
{
    public class WCFInterceptor : IInterceptor
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