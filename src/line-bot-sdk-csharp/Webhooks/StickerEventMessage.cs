namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Message object which contains the sticker data sent from the source. For a list of basic LINE stickers and sticker IDs, see sticker list.
    /// </summary>
    public class StickerEventMessage : EventMessage
    {
        public string PackageId { get; }

        public string StickerId { get; }
        public StickerResourceType StickerResourceType { get; }
        public string[] Keywords { get; }
        public string Text { get; }

        public StickerEventMessage(string id, string packageId, string stickerId, string[] keywords, StickerResourceType stickerResourceType, string text) : base(EventMessageType.Sticker, id)
        {
            PackageId = packageId;
            StickerId = stickerId;
            Keywords = keywords;
            StickerResourceType = stickerResourceType;
            Text = text;
        }
    }
}
