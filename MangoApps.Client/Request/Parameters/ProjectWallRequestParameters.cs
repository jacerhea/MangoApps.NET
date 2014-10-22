using System.Collections.Generic;

namespace MangoApps.Client.Request.Parameters
{
    class ProjectWallRequestParameters
    {
        public ProjectWallFeed Feed { get; set; }
    }

    public class ProjectWallFeed
    {
        public string ProjectId { get; set; }
        public List<string> Attachments { get; set; }
        public string FeedType { get; set; }
        public string Body { get; set; }
    }
}
