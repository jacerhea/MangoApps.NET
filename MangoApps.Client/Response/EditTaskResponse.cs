using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class EditTaskResponse : TransactionResponse
    {
        public SingleTask Task { get; set; }
    }
}
