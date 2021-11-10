using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// Response from Get Followers IDs API
    /// </summary>
    public class FollowerIds
    {
        /// <summary>
        /// List of user IDs of the followers.
        /// Max: 1000 user IDs
        /// The default value is 300
        /// </summary>
        public IList<string> UserIds { get; set; }

        /// <summary>
        /// continuationToken
        /// A continuation token to get the next array of user IDs.
        /// </summary>
        public string Next { get; set; }
    }
}
