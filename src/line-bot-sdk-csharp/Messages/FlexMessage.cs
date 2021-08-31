using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#flex-message
    /// https://developers.line.biz/en/reference/messaging-api/#flex-message
    /// </summary>
    public class FlexMessage : ISendMessage
    {
        /// <summary>
        /// Flex
        /// </summary>
        public MessageType Type { get; } = MessageType.Flex;
        public QuickReply QuickReply { get; set; }
        public Sender Sender { get; set; }
        /// <summary>
        /// Alternative text (Max: 400 characters)
        /// </summary>
        public string AltText { get; set; }
        /// <summary>
        /// Flex Message container
        /// </summary>
        public IFlexContainer Contents { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="altText"></param>
        /// <param name="contents"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public FlexMessage(string altText, IFlexContainer contents, QuickReply quickReply = null, Sender sender = null)
        {
            QuickReply = quickReply;
            AltText = altText.Substring(0, Math.Min(altText.Length, 400));
            Contents = contents;
            Sender = sender;
        }

        public static BubbleContainerFlexMessage CreateBubbleMessage(string altText, IFlexContainer contents)
        {
            return new BubbleContainerFlexMessage(altText, contents)
            {
                Contents = new BubbleContainer()
            };
        }

        public static CarouselContainerFlexMessage CreateCarouselMessage(string altText, IFlexContainer contents)
        {
            return new CarouselContainerFlexMessage(altText, contents)
            {
                Contents = new CarouselContainer()
            };
        }
    }

}
