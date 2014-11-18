namespace MangoApps.Client
{
    public static class URL
    {
        public const string Login = "/api/login";
        public const string Logout = "/api/logout";
        public static string Users = "/api/users";
        public static string Groups = "/api/groups";
        public static string AddMembersToGroup = "/api/groups/{group_id}/members/manage";
        public static string RemovedMembersFromGroup = "/api/groups/{group_id}/members/manage";
        public static string Projects = "/api/projects";
        public static string ProjectTimeSheet = "/api/projects/{project_id}/time_logs";
        public static string AddMembersToProject = "/api/projects/{project_id}/members/manage";
        public const string Comments = "/api/comments";
        public static string Feeds = "/api/feeds";
        public static string DirectMessages = "/api/feeds/direct_messages";
        public static string LikeFeed = "/api/feeds/{feed_id}/like";
        public static string MarkFeedAsRead = "/api/feeds/{feed_id}/unread";
        public static string MarkMultipleFeedsAsRead = "/api/feeds/mark_all_as_read";
        public static string BookmarkFeed = "/api/feeds/{feed_id}/bookmark";
        public static string AskAQuestion = "/api/feeds/ask_a_question";
        public static string ChangeTeamFeedVisibility = "/api/feeds/chage_feed_visibility";
        public static string PostVoteResponse = "/api/feeds/{poll_id}/comment";
        public static string Conversations = "/api/conversations";
        public static string LeaveProjectOrGroup = "/api/conversations/{conversation_id}/leave";
        public static string Wikis = "/api/wikis";
        public static string Posts = "/api/posts";
        public static string Folders = "/api/folders";
        public static string MoveFolders = "/api/folders/move";
        public static string Task = "/api/tasks";
        public static string Huddle = "/api/huddle";
        public static string ChangePassword = "/api/users/change_password";
        public static string ActiveDeactivateUsers = "/api/users/change_user_state.json?user_ids=<uid1>,<uid2>&new_state=<user_state>";
        public static string UserWall = "/api/users/{user_id}/wall";
        public static string LikeComment = "/api/comments/{comment_id}/like";
        public static string TaskLifeCycle = "/api/tasks/{task_id}/lifecycle";
        public static string GetFilesInsideFolder = "/api/folders/{folder_id}/files";
        public static string GetFilesOfTeam = "/api/conversations/{conversation_id}/attachments";
    }
}
