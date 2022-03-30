namespace LineMessagingAPI
{
    /// <summary>
    /// Image
    /// https://developers.line.me/ja/reference/messaging-api/#image-message
    /// https://developers.line.me/en/reference/messaging-api/#image-message
    /// </summary>
    public class ImageMessage : ISendMessage
    {
        /// <summary>
        /// Image
        /// </summary>
        public MessageType Type { get; } = MessageType.Image;
        public QuickReply? QuickReply { get; set; }
        public Sender? Sender { get; set; }

        /// <summary>
        /// Image URL (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Max image size: No limits
        /// Max file size: 10 MB
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// Preview image URL (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Max image size: No limits
        /// Max file size: 1 MB
        /// </summary>
        public string PreviewImageUrl { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="originalContentUrl"></param>
        /// <param name="previerImageUrl"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public ImageMessage(string originalContentUrl, string previerImageUrl, QuickReply? quickReply = null, Sender? sender = null)
        {
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previerImageUrl;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}