namespace LineMessagingAPI
{
    /// <summary>
    /// Response from Get group member user IDs API
    /// </summary>
    public class GroupSummary
    {
        /// <summary>
        /// Group ID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// Group icon URL
        /// </summary>
        public string PictureUrl { get; set; }
    }
}