using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class SingleTaskResponse : TransactionResponse
    {
        public SingleTask Task { get; set; }

    }

    [DataContract]
    public class SingleTask
    {
        public string ProfilePosition { get; set; }
        public string CreatedAt { get; set; }
        public string AssignedTo { get; set; }
        public string DueOn { get; set; }
        public string Bucket { get; set; }
        public string RejectedOn { get; set; }
        public string UpdatedAt { get; set; }
        public string AcceptedOn { get; set; }
        public string FinishedOn { get; set; }
        public string ProjectId { get; set; }
        public string Notes { get; set; }
        public string ReopenedOn { get; set; }
        public string ProjectPosition { get; set; }
        public string MilestonePosition { get; set; }
        public string DocumentPosition { get; set; }
        public string BestCase { get; set; }
        public string PersonalPriority { get; set; }
        public string AssignedOn { get; set; }
        public string CreatorId { get; set; }
        public string DeliveredOn { get; set; }
        public string StartOn { get; set; }
        public string Type { get; set; }
        public string BestCaseUnit { get; set; }
        public string WorstCaseUnit { get; set; }
        public string Milestone { get; set; }
        public string DocumentPriority { get; set; }
        public string Status { get; set; }
        public string ReassignedOn { get; set; }
        public string RestartedOn { get; set; }
        public string StartedOn { get; set; }
        public string Due { get; set; }
        public string Visibility { get; set; }
        public string WorstCase { get; set; }
        public string ProjectPriority { get; set; }
        public string SubTasks { get; set; }
        public string NextActions { get; set; }
    }
}
