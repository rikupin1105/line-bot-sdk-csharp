namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#get-bot-info-response
    /// </summary>
    public class BotInfo
    {
        public string userID { get; set; }
        public string BasicId { get; set; }
        public string PremiumId { get; set; }
        public string DisplayName { get; set; }
        public string PictureUrl { get; set; }
        public string ChatMode { get; set; }
        public string MarkAsReadMode { get; set; }
    }
}
