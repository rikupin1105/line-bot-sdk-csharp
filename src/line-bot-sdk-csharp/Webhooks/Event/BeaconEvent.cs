namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Event object for when a user enters or leaves the range of a LINE Beacon. You can reply to beacon events.
    /// https://developers.line.me/en/docs/messaging-api/reference/#beacon-event
    /// </summary>
    public class BeaconEvent : ReplyableEvent
    {
        public Beacon Beacon { get; }

        public BeaconEvent(WebhookEventSource source, long timestamp, string replyToken, string hwid, BeaconType beaconType, string dm, string mode, string webhookEventId, DeliveryContext deliveryContext)
            : base(WebhookEventType.Beacon, source, timestamp, replyToken, mode, webhookEventId, deliveryContext)
        {
            Beacon = new Beacon(hwid, beaconType, dm);
        }
    }
}
