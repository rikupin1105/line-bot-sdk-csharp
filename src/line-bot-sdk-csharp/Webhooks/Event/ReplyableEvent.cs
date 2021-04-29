namespace LineMessagingAPI.Webhooks
{
    public abstract class ReplyableEvent : WebhookEvent
    {
        public string ReplyToken { get; }

        public ReplyableEvent(WebhookEventType eventType, WebhookEventSource source, long timestamp, string replyToken, string mode)
            : base(eventType, source, timestamp, mode)
        {
            ReplyToken = replyToken;
        }
    }
}
