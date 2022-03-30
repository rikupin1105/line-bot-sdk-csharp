namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#sticker-message
    /// https://developers.line.biz/en/reference/messaging-api/#sticker-message
    /// </summary>
    public class StickerMessage : ISendMessage
    {
        /// <summary>
        /// Sticker
        /// </summary>
        public MessageType Type { get; } = MessageType.Sticker;

        /// <summary>
        /// These properties are used for the quick reply feature
        /// </summary>
        public QuickReply? QuickReply { get; set; }
        public Sender? Sender { get; set; }

        /// <summary>
        /// Package ID for a set of stickers. For information on package IDs, see the List of available stickers.
        /// </summary>
        public string PackageId { get; }

        /// <summary>
        /// Sticker ID. For a list of sticker IDs for stickers that can be sent with the Messaging API, see the List of available stickers.
        /// </summary>
        public string StickerId { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="packageId"></param>
        /// <param name="stickerId"></param>
        /// <param name="quickReply"></param>
        /// <param name="sender"></param>
        public StickerMessage(string packageId, string stickerId, QuickReply? quickReply = null, Sender? sender = null)
        {
            PackageId = packageId;
            StickerId = stickerId;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}