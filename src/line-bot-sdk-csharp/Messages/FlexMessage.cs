using System;

namespace LineMessagingAPI
{
    public class FlexMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Flex;
        public QuickReply QuickReply { get; set; }
        public IFlexContainer Contents { get; set; }
        public MessageSender Sender { get; set; }
        public string AltText { get; set; }
        public FlexMessage(string altText, IFlexContainer contents, QuickReply quickReply = null, MessageSender messageSender = null)
        {
            QuickReply = quickReply;
            AltText = altText.Substring(0, Math.Min(altText.Length, 400));
            Contents = contents;
            Sender = messageSender;
        }

        public static BubbleContainerFlexMessage CreateBubbleMessage(string altText)
        {
            return new BubbleContainerFlexMessage(altText)
            {
                Contents = new BubbleContainer()
            };
        }

        public static CarouselContainerFlexMessage CreateCarouselMessage(string altText)
        {
            return new CarouselContainerFlexMessage(altText)
            {
                Contents = new CarouselContainer()
            };
        }
    }

}
