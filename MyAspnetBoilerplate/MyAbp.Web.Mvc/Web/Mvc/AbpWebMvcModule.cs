using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyAbp.Web.Mvc.Web.Mvc
{
    public class AbpWebMvcModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication application)
        {
            //注册NET 管道第七个事件
            application.PostResolveRequestCache += Application_PostResolveRequestCache;
        }

        private void Application_PostResolveRequestCache(object sender, EventArgs e)
        {
            var application = sender as HttpApplication;
            var context = application.Context;

            context.Response.Write("hello word");
            context.Response.End();
        }
    }
}
