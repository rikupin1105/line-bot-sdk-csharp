using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#template-messages
    /// https://developers.line.biz/en/reference/messaging-api/#template-messages
    /// </summary>
    public class TemplateMessage : ISendMessage
    {
        /// <summary>
        /// Template
        /// </summary>
        public MessageType Type { get; } = MessageType.Template;
        public QuickReply? QuickReply { get; set; }
        public Sender? Sender { get; set; }

        /// <summary>
        /// A Buttons, Confirm, Carousel, or Image Carousel object.
        /// </summary>
        public ITemplate Template { get; }

        /// <summary>
        /// Alternative text. (Max: 400 characters)
        /// </summary>
        public string AltText { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="altText"></param>
        /// <param name="template"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public TemplateMessage(string altText, ITemplate template, QuickReply? quickReply = null, Sender? sender = null)
        {
            AltText = altText[..Math.Min(altText.Length, 400)];
            Template = template;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}
