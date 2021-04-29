using System;

namespace LineMessagingAPI
{
    public class BubbleContainerFlexMessage : FlexMessage
    {
        /// <summary>
        /// Sets a Bubble container to the FlexMessage object.
        /// </summary>
        /// <param name="bubbleContainer"></param>
        /// <returns>Flex Message</returns>
        public BubbleContainerFlexMessage SetBubbleContainer(BubbleContainer bubbleContainer)
        {
            Contents = bubbleContainer ?? throw new ArgumentNullException(nameof(bubbleContainer));
            return this;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="altText">alt text</param>
        public BubbleContainerFlexMessage(string altText, IFlexContainer contents) : base(altText, contents)
        {

        }

        /// <summary>
        /// Sets a QuickReply object to the FlexMessage objecy.
        /// </summary>
        /// <param name="quickReply"></param>
        /// <returns>Flex Message</returns>
        public BubbleContainerFlexMessage SetQuickReply(QuickReply quickReply)
        {
            QuickReply = quickReply;
            return this;
        }
    }
}
