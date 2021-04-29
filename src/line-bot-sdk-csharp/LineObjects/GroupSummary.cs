using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// Response from Get group member user IDs API
    /// </summary>
    public class GroupSummary
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string PictureUrl { get; set; }
    }
}
