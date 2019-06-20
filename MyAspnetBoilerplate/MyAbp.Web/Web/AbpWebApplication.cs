using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyAbp.Web.Web
{
    public abstract class AbpWebApplication:HttpApplication
    {
        protected virtual void Application_Start(object sender,EventArgs e)
        {
            
        }
    }
}
