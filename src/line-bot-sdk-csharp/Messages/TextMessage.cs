using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// Text
    /// https://developers.line.me/en/docs/messaging-api/reference/#text
    /// </summary>
    public class TextMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Text;

        /// <summary>
        /// These properties are used for the quick reply feature
        /// </summary>
        public QuickReply QuickReply { get; set; }

        public MessageSender Sender { get; set; }

        /// <summary>
        /// Message text
        /// Max: 2000 characters
        /// </summary>
        public string Text { get; set; }

        //public Emoji[] Emojis { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="text">
        /// Message text
        /// Max: 2000 characters
        /// </param>
        /// <param name="quickReply">
        /// QuickReply
        /// </param>
        public TextMessage(string text, QuickReply quickReply = null, MessageSender messageSender=null)
        {
            Text = text.Substring(0, Math.Min(text.Length, 5000));
            QuickReply = quickReply;
            Sender = messageSender;
        }
    }
}
