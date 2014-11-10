namespace MangoApps.Client.Request.Parameters
{
    public class GroupWallRequestParameters
    {
        public GroupWallFeed Feed { get; set; }
    }

    public abstract class GroupWallFeed
    {
        public string Body { get; set; }
        public string GroupId { get; set; }
        public string FeedType { get; set; }
    }
}
