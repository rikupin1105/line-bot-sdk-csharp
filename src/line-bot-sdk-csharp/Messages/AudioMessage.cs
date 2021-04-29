namespace LineMessagingAPI
{
    public class AudioMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Audio;
        public QuickReply QuickReply { get; set; }
        public MessageSender Sender { get; set; }
        public string OriginalContentUrl { get; }
        public long Duration { get; }
        public AudioMessage(string originalContentUrl, long duration, QuickReply quickReply = null, MessageSender messageSender = null)
        {
            OriginalContentUrl = originalContentUrl;
            Duration = duration;
            QuickReply = quickReply;
            Sender = messageSender;
        }
    }
}
