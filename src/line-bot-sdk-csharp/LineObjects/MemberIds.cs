using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// Response from Get group member user IDs API
    /// </summary>
    public class GroupMemberIds
    {
        /// <summary>
        /// List of user IDs of the members in the group.
        /// Max: 100 user IDs
        /// </summary>
        public IList<string> MemberIds { get; set; }

        /// <summary>
        /// continuationToken
        /// Only returned when there are more user IDs remaining in memberIds
        /// </summary>
        public string Next { get; set; }
    }
}
