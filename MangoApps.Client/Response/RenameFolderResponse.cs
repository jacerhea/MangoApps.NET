namespace MangoApps.Client.Response
{
    public class RenameFolderResponse : TransactionResponse
    {
        public Folder Folder { get; set; }
    }

    public class Folder
    {
        public string Name { get; set; }
        public string ConversationId { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string IsVirtualFolder { get; set; }
        public string MLink { get; set; }
    }
}
