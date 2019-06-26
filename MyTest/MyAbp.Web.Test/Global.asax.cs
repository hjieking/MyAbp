using MyAbp.Web.Mvc.Web.Mvc;
using MyAbp.Web.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MyAbp.Web.Test
{
    public class Global : AbpWebApplication<AbpWebMvcModule>
    {

        protected override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);
        }

       
    }
}