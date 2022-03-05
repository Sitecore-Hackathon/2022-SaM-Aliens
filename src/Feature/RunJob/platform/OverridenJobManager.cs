using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sitecore.Abstractions;
using Sitecore.Jobs;

namespace Foundation.RunJob.Platform
{
    public class OverridenJobManager : DefaultJobManager
    {
        public override BaseJob[] GetJobs()
        {
            return base.GetJobs();
        }


        public override void Start(BaseJob job)
        {
            base.Start(job);
        }

        public override BaseJob Start(BaseJobOptions options)
        { 
            var json = new JObject(options);
            var defaultOptions = new DefaultJobOptions(options.JobName, options.Category, options.SiteName,
                options.CustomData, options.Method.Method.Name, options.Parameters, true);

            return base.Start(defaultOptions);
        }
    }
}