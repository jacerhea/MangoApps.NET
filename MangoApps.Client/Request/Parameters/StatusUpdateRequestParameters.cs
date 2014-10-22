namespace MangoApps.Client.Request.Parameters
{
    public class StatusUpdateRequestParameters
    {
        public StatusUpdateFeed Feed { get; set; }
    }

    public class StatusUpdateFeed
    {
        public string FeedType { get; set; }
        public string Body { get; set; }
    }
}
