namespace LineMessagingAPI.Core
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-profile
    /// https://developers.line.biz/en/reference/messaging-api/#get-profile
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// User's language, as a BCP 47 (opens new window)language tag. Example: en for English. The language property is returned only in the following situations:
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Profile image URL. "https" image URL. Not included in the response if the user doesn't have a profile image.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// User's status message. Not included in the response if the user doesn't have a status message.
        /// </summary>
        public string StatusMessage { get; set; }
    }
}