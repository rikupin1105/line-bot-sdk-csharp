using LineMessagingAPI.Core;

namespace LineMessagingAPI.Webhook
{
    /// <summary>
    /// Message object which contains the text sent from the source.
    /// </summary>
    public class TextEventMessage : EventMessage
    {
        public string Text { get; }
        public Emoji[] Emojis { get; }
        public Mention Mention { get; }

        public TextEventMessage(string id, string text, Emoji[] emojis = null, Mention mention = null) : base(EventMessageType.Text, id)
        {
            Text = text;
            Emojis = emojis;
            Mention = mention;
        }
    }
}
