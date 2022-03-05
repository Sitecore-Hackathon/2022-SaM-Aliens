using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Foundation.RunJob.Platform
{
    public class RegisterRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapHttpRoute("testController", "samaliens/api/test/{action}",
                new
                {
                    controller = "Test"
                }
            );
        }
    }
}
