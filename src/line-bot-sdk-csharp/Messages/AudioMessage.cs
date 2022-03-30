namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#audio-message
    /// https://developers.line.biz/en/reference/messaging-api/#audio-message
    /// </summary>
    public class AudioMessage : ISendMessage
    {
        /// <summary>
        /// Audio
        /// </summary>
        public MessageType Type { get; } = MessageType.Audio;
        public QuickReply? QuickReply { get; set; }
        public Sender? Sender { get; set; }
        /// <summary>
        /// URL of the audio file (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// m4a
        /// Max file size: 200 MB
        /// </summary>
        public string OriginalContentUrl { get; }
        /// <summary>
        /// Length of audio file (milliseconds)
        /// </summary>
        public long Duration { get; }

        /// <summary>
        /// Constructror
        /// </summary>
        /// <param name="originalContentUrl"></param>
        /// <param name="duration"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public AudioMessage(string originalContentUrl, long duration, QuickReply? quickReply = null, Sender? sender = null)
        {
            OriginalContentUrl = originalContentUrl;
            Duration = duration;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}