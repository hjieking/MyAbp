using MyAbp.Web.Mvc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyAbp.Web.Web
{
    public abstract class AbpWebApplication<HJIHttpModule> :HttpApplication where HJIHttpModule: IHttpModule
    {
        private static IHttpModule HjIHttpModule { get; } = GetHttpModule();
        protected virtual void Application_Start(object sender, EventArgs e)
        {
            HjIHttpModule.Init(this);
        }
        public static IHttpModule GetHttpModule()
        {
            return (IHttpModule)new AbpWebMvcModule();
        }
    }
}
