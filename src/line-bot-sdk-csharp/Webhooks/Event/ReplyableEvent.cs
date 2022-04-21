namespace LineMessagingAPI.Webhooks
{
    public abstract class ReplyableEvent : WebhookEvent
    {
        public string ReplyToken { get; }

        public ReplyableEvent(WebhookEventType eventType, WebhookEventSource source, long timestamp, string replyToken, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(eventType, source, timestamp, mode, webhookEventId, deliveryContext)
        {
            ReplyToken = replyToken;
        }
    }
}
