using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class CreateAHuddleResponse : TransactionResponse
    {
        public Huddle Huddle { get; set; }
    }

    [DataContract]
    public class Huddle
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public HuddleMembers Members { get; set; }
        public string Id { get; set; }
        public string Privacy { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
    }

    public class HuddleMembers
    {
    }
}
