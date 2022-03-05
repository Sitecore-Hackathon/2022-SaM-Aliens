using System.Web.Http;
using Sitecore.Abstractions;
using Sitecore.Jobs;

namespace Foundation.RunJob.Platform.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult CancelJob()
        {
            var test = "test";
            
            
            //var abortable = new AbortableJob(new DefaultJobOptions(test, test, test, test, test));
            
            
            var jobs = JobManager.GetJobs();
    
            return Ok();
        }
    }
}
