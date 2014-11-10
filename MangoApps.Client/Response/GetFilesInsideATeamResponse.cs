using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Client.Response
{
    public class GetFilesInsideATeamResponse : TransactionResponse
    {
        public int Count { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    public class Attachment
    {
        public string FileName { get; set; }
        public string Size { get; set; }
        public string ContentType { get; set; }
        public string ShortURL { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string MLink { get; set; }
        public string PreviewURL { get; set; }
    }
}
