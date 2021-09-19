﻿namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Image event message
    /// </summary>
    public class ImageEventMessage : EventMessage
    {
        /// <summary>
        /// ContentProvider
        /// </summary>
        public ContentProvider ContentProvider { get; }
        public ImageSet ImageSet { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="contentProvider"></param>
        /// <param name="imageSet"></param>
        public ImageEventMessage(EventMessageType type, string id, ContentProvider contentProvider = null, ImageSet imageSet = null) : base(type, id)
        {
            ContentProvider = contentProvider;
            ImageSet = imageSet;
        }
    }
}
