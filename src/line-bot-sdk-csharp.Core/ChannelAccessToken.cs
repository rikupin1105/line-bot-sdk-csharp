namespace LineMessagingAPI.Core
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#issue-shortlived-channel-access-token
    /// https://developers.line.biz/en/reference/messaging-api/#issue-shortlived-channel-access-token
    /// </summary>
    public class ChannelAccessToken
    {
        /// <summary>
        /// Short-lived channel access token. Valid for 30 days.
        /// Note: Channel access tokens cannot be refreshed.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Time until channel access token expires in seconds from time the token is issued
        /// </summary>
        public long ExpiresIn { get; set; }

        /// <summary>
        /// Bearer
        /// </summary>
        public string TokenType { get; } = "Bearer";
    }
}