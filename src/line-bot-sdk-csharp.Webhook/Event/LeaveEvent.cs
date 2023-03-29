namespace LineMessagingAPI.Webhook.Event
{
    /// <summary>
    /// Event object for when your account leaves a group.
    /// No event is generated when your account leaves a room.
    /// Leave events are not generated if you leave a group or room using leave group or leave room.
    /// </summary>
    public class LeaveEvent : WebhookEvent
    {
        public LeaveEvent(WebhookEventSource source, long timestamp, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.Leave, source, timestamp, mode, webhookEventId, deliveryContext)
        {
        }
    }
}
