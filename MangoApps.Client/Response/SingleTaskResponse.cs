using System.Collections.Generic;
using System.Runtime.Serialization;
using MangoApps.Client.Request;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class SingleTaskResponse : TransactionResponse
    {
        [DataMember(Name = "task")]
        public SingleTask Task { get; set; }

    }

    [DataContract]
    public class SingleTask
    {
        [DataMember(Name = "profile_position")]
        public string ProfilePosition { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "assigned_to")]
        public string AssignedTo { get; set; }

        [DataMember(Name = "due_on")]
        public string DueOn { get; set; }

        [DataMember(Name = "bucket")]
        public string Bucket { get; set; }

        [DataMember(Name = "milestone_id")]
        public string MilestoneId { get; set; }

        [DataMember(Name = "rejected_on")]
        public string RejectedOn { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "accepted_on")]
        public string AcceptedOn { get; set; }

        [DataMember(Name = "finished_on")]
        public string FinishedOn { get; set; }

        [DataMember(Name = "project_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "reopened_on")]
        public string ReopenedOn { get; set; }

        [DataMember(Name = "project_position")]
        public string ProjectPosition { get; set; }

        [DataMember(Name = "milestone_position")]
        public string MilestonePosition { get; set; }

        [DataMember(Name = "document_position")]
        public string DocumentPosition { get; set; }

        [DataMember(Name = "best_case")]
        public string BestCase { get; set; }

        [DataMember(Name = "personal_priority")]
        public string PersonalPriority { get; set; }

        [DataMember(Name = "assigned_on")]
        public string AssignedOn { get; set; }

        [DataMember(Name = "creator_id")]
        public string CreatorId { get; set; }

        [DataMember(Name = "delivered_on")]
        public string DeliveredOn { get; set; }

        [DataMember(Name = "start_on")]
        public string StartOn { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "best_case_unit")]
        public string BestCaseUnit { get; set; }

        [DataMember(Name = "worst_case_unit")]
        public string WorstCaseUnit { get; set; }

        [DataMember(Name = "feed_id")]
        public string FeedId { get; set; }

        [DataMember(Name = "reviewers")]
        public List<Reviewer> Reviewers { get; set; }

        [DataMember(Name = "rejected_on")]
        public string DocumentPriority { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "reassigned_on")]
        public string ReassignedOn { get; set; }

        [DataMember(Name = "restarted_on")]
        public string RestartedOn { get; set; }

        [DataMember(Name = "started_on")]
        public string StartedOn { get; set; }

        [DataMember(Name = "due")]
        public string Due { get; set; }

        [DataMember(Name = "visibility")]
        public string Visibility { get; set; }

        [DataMember(Name = "worst_case")]
        public string WorstCase { get; set; }

        [DataMember(Name = "project_priority")]
        public string ProjectPriority { get; set; }

        [DataMember(Name = "sub_tasks")]
        public string SubTasks { get; set; }

        [DataMember(Name = "next_actions")]
        public List<ItemContainer> NextActions { get; set; }
    }

    public class Reviewer
    {
    }
}
