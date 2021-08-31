namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-bot-info-response
    /// https://developers.line.biz/en/reference/messaging-api/#get-bot-info-response
    /// </summary>
    public class BotInfo
    {
        /// <summary>
        /// Bot's user ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Bot's basic ID
        /// </summary>
        public string BasicId { get; set; }
        /// <summary>
        /// Bot's premium ID. Not included in the response if the premium ID isn't set.
        /// </summary>
        public string PremiumId { get; set; }
        /// <summary>
        /// Bot's display name
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Profile image URL. "https" image URL. Not included in the response if the bot doesn't have a profile image.
        /// </summary>
        public string PictureUrl { get; set; }
        /// <summary>
        /// Bot's response mode set in the LINE Official Account Manager
        /// </summary>
        public string ChatMode { get; set; }
        /// <summary>
        /// Automatic read setting for messages. If the bot's response mode is "Bot", auto is returned. If the response mode is "Chat", manual is returned.
        /// </summary>
        public string MarkAsReadMode { get; set; }
    }
}