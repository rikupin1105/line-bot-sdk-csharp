namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Message object which contains the sticker data sent from the source. For a list of basic LINE stickers and sticker IDs, see sticker list.
    /// </summary>
    public class FollowEventMessage : ReplyableEvent
    {
        public FollowEventMessage(WebhookEventSource source, long timestamp, string replyToken, string mode)
            : base(WebhookEventType.Follow, source, timestamp, replyToken, mode)
        {
        }
    }
}
