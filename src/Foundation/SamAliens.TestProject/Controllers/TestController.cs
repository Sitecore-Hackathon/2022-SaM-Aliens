using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Maintenance;
using Sitecore.Jobs;

namespace SamAliens.TestProject.Controllers
{
    [RoutePrefix("sam-aliens/api/test")]
    public class TestController : ApiController
    {
        // GET: Test
        public IHttpActionResult Index()
        {
            var abortableJob = new AbortableJob(new DefaultJobOptions("test", "test", "test", new object(), "test"));
            
            var jobs = JobManager.GetJobs();
            return Ok();
        }
    }
}