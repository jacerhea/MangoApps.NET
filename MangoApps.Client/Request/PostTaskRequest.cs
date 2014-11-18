using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class PostTaskRequest
    {
        [DataMember(Name = "task")]
        public PostTask Task { get; set; }
    }

    [DataContract]
    public class PostTask
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "assigned_to")]
        public string AssignedTo { get; set; }

        [DataMember(Name = "visibility")]
        public string Visibility { get; set; }

        [DataMember(Name = "best_case")]
        public string BestCase { get; set; }

        [DataMember(Name = "best_case_unit")]
        public string BestCaseUnit { get; set; }

        [DataMember(Name = "worst_case")]
        public string WorstCase { get; set; }

        [DataMember(Name = "worst_case_unit")]
        public string WorstCaseUnit { get; set; }

        [DataMember(Name = "start_on")]
        public string StartOn { get; set; }

        [DataMember(Name = "attachments")]
        public string Attachments { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "project_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "due_on")]
        public string DueOn { get; set; }

        [DataMember(Name = "from_feed_id")]
        public string FromFeedId { get; set; }

        [DataMember(Name = "reviewers")]
        public List<Reviewer> Reviewers { get; set; }

        [DataMember(Name = "milestone_id")]
        public string MilestoneId { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }
    }

    [DataContract]
    public class Reviewer
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
