namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#video-message
    /// https://developers.line.biz/en/reference/messaging-api/#video-message
    /// </summary>
    public class VideoMessage : ISendMessage
    {
        /// <summary>
        /// Video
        /// </summary>
        public MessageType Type { get; } = MessageType.Video;
        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }

        /// <summary>
        /// URL of video file (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// mp4
        /// Max file size: 10 MB
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// URL of preview image (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Max file size: 1 MB
        /// </summary>
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// ID used to identify the video when Video viewing complete event occurs. If you send a video message with trackingId added, the video viewing complete event occurs when the user finishes watching the video.
        /// Max: 100 characters
        /// Supported character types: Half-width alphanumeric characters (a-z, A-Z, 0-9) and symbols (-.=,+*()%$&;:@{}!?<>[])
        /// </summary>
        public string TrackingId { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="originalContentUrl"></param>
        /// <param name="previerImageUrl"></param>
        /// <param name="trackingId"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public VideoMessage(string originalContentUrl, string previerImageUrl, string trackingId = null, QuickReply quickReply = null, Sender sender = null)
        {
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previerImageUrl;
            QuickReply = quickReply;
            Sender = sender;
            TrackingId = trackingId;
        }
    }
}