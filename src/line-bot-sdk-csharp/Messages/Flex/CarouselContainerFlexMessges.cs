﻿using System;

namespace LineMessagingAPI
{
    public class CarouselContainerFlexMessage : FlexMessage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="altText">alt text</param>
        public CarouselContainerFlexMessage(string altText, IFlexContainer contents) : base(altText, contents)
        {
        }

        /// <summary>
        /// Add a bubble container to the FlexMessage object.
        /// </summary>
        /// <param name="bubbleContainer">Bubble Container</param>
        /// <returns>Flex Message</returns>
        public CarouselContainerFlexMessage AddBubbleContainer(BubbleContainer bubbleContainer)
        {
            if (bubbleContainer is null) { throw new ArgumentNullException(nameof(bubbleContainer)); }
            var contents = (Contents as CarouselContainer).Contents;
            contents.Add(bubbleContainer);
            return this;
        }

        /// <summary>
        /// Sets a QuickReply object to the QuickReply object.
        /// </summary>
        /// <param name="quickReply"></param>
        /// <returns>Flex Message</returns>
        public CarouselContainerFlexMessage SetQuickReply(QuickReply quickReply)
        {
            QuickReply = quickReply;
            return this;
        }
    }
}
