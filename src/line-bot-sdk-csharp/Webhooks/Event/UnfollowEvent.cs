namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Event object for when your account is blocked.
    /// </summary>
    public class UnfollowEvent : WebhookEvent
    {
        public UnfollowEvent(WebhookEventSource source, long timestamp, string mode)
            : base(WebhookEventType.Unfollow, source, timestamp, mode)
        {

        }
    }
}
