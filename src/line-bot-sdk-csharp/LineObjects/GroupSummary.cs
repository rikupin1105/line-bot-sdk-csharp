namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-group-summary
    /// https://developers.line.biz/en/reference/messaging-api/#get-group-summary
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