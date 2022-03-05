using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Foundation.RunJob.Rendering.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureRunJob(this RenderingEngineOptions options)
        {
            /*
            options.AddModelBoundView<MyModel>("MyView");
            */
            return options;
        }
    }
}