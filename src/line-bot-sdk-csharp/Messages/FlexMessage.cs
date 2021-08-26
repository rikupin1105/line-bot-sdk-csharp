using System;

namespace LineMessagingAPI
{
    public class FlexMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Flex;
        public QuickReply QuickReply { get; set; }
        public IFlexContainer Contents { get; set; }
        public Sender Sender { get; set; }
        public string AltText { get; set; }
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
