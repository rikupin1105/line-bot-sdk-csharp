using System;
using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#imagemap-message
    /// https://developers.line.biz/en/reference/messaging-api/#imagemap-message
    /// </summary>
    public class ImagemapMessage : ISendMessage
    {
        /// <summary>
        /// Imagemap
        /// </summary>
        public MessageType Type { get; } = MessageType.Imagemap;
        public QuickReply? QuickReply { get; set; }
        public Sender? Sender { get; set; }

        /// <summary>
        /// Base URL of image (Max: 2000 characters)
        /// HTTPS over TLS 1.2 or later
        /// </summary>
        public string BaseUrl { get; }

        /// <summary>
        /// Alternative text (Max: 400 characters)
        /// </summary>
        public string AltText { get; }

        /// <summary>
        /// Width of base image (set to 1040px）
        /// Height of base image（set to the height that corresponds to a width of 1040px）
        /// </summary>
        public BaseSize BaseSize { get; }

        /// <summary>
        /// Video to play on imagemap
        /// </summary>
        public ImagemapVideo? Video { get; }

        /// <summary>
        /// Action when tapped.
        /// Max: 50
        /// </summary>
        public IList<IImagemapAction> Actions { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="altText"></param>
        /// <param name="baseSize"></param>
        /// <param name="actions"></param>
        /// <param name="quickReply"></param>
        /// <param name="video"></param>
        /// <param name="sender"></param>
        public ImagemapMessage(string baseUrl, string altText, BaseSize baseSize, IList<IImagemapAction> actions, ImagemapVideo? video = null, QuickReply? quickReply = null, Sender? sender = null)
        {
            BaseUrl = baseUrl[..Math.Min(altText.Length, 2000)];
            AltText = altText[..Math.Min(altText.Length, 400)];
            BaseSize = baseSize;
            Actions = actions;
            QuickReply = quickReply;
            Video = video;
            Sender = sender;
        }
    }
}
