using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.me/ja/reference/messaging-api/#text-message
    /// https://developers.line.me/en/reference/messaging-api/#text-message
    /// </summary>
    public class TextMessage : ISendMessage
    {
        /// <summary>
        /// Text
        /// </summary>
        public MessageType Type { get; } = MessageType.Text;
        /// <summary>
        /// Message text. You can include the following emoji:
        /// - LINE emojis. Use a $ character as a placeholder and specify the product ID and emoji ID of the LINE emoji you want to use in the emojis property. For more information, see List of available LINE emojis.
        /// - Unicode emojis
        /// - (Deprecated) LINE original unicode emojis. See the Unicode code point table for LINE original emoji for details.
        /// Max: 5000 characters
        /// "LINE original unicode emojis" are deprecated: "LINE original unicode emojis" are deprecated due to the older version. Since this type of emojis will come to end-of-life, we recommend that you use "LINE Emoji" with the emojis property instead. For more information, see List of available LINE emojis in the Messaging API documentation.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// One or more LINE emoji.
        /// Max: 20 emojis
        /// </summary>
        public Emoji[] Emojis { get; set; }


        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="text"></param>
        /// <param name="emojis"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public TextMessage(string text, Emoji[] emojis = null, QuickReply quickReply = null, Sender sender = null)
        {
            Text = text.Substring(0, Math.Min(text.Length, 5000));
            Emojis = emojis;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}