namespace LineMessagingAPI
{
    public class AudioMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Audio;
        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }
        /// <summary>
        /// URL of the audio file (Max: 2000 characters)
        /// HTTPS
        /// m4a
        /// Max: 200 MB
        /// </summary>
        public string OriginalContentUrl { get; }
        public long Duration { get; }
        /// <summary>
        /// Constructror
        /// </summary>
        /// <param name="originalContentUrl"></param>
        /// URL of the audio file (Max: 2000 characters)
        /// HTTPS
        /// m4a
        /// Max: 200 MB
        /// <param name="duration"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public AudioMessage(string originalContentUrl, long duration, QuickReply quickReply = null, Sender sender = null)
        {
            OriginalContentUrl = originalContentUrl;
            Duration = duration;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}
