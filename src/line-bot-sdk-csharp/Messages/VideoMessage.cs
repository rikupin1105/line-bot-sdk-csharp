namespace LineMessagingAPI
{
    /// <summary>
    /// Video
    /// https://developers.line.me/en/docs/messaging-api/reference/#video
    /// </summary>
    public class VideoMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Video;

        /// <summary>
        /// These properties are used for the quick reply feature
        /// </summary>
        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }

        /// <summary>
        /// URL of video file (Max: 1000 characters)
        /// HTTPS
        /// mp4
        /// Less than 1 minute
        /// Max: 10 MB
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// URL of preview image (Max: 1000 characters)
        /// HTTPS
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </summary>
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// 動画視聴完了イベントが発生したときに、動画を識別するためのID。trackingIdを付与した動画メッセージを送信した場合に限り、ユーザーが動画の視聴を完了すると動画視聴完了イベントが発生します。
        /// </summary>
        public string TrackingId { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="originalContentUrl">
        /// URL of video file (Max: 1000 characters)
        /// HTTPS
        /// mp4
        /// Less than 1 minute
        /// Max: 10 MB
        /// </param>
        /// <param name="previerImageUrl">
        /// URL of preview image (Max: 1000 characters)
        /// HTTPS
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </param>
        /// <param name="quickReply">
        /// QuickReply
        /// </param>
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
