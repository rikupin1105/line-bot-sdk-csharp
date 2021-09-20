namespace LineMessagingAPI.Webhooks
{
    public class VideoViewingCompleteEvent : ReplyableEvent
    {
        public VideoPlayComplete VideoPlayComplete;

        public VideoViewingCompleteEvent(WebhookEventSource source, long timestamp, string mode, string replyToken, VideoPlayComplete videoPlayComplete) : base(WebhookEventType.VideoPlayComplete, source, timestamp, replyToken, mode)
        {
            VideoPlayComplete = videoPlayComplete;
        }
    }
    public class VideoPlayComplete
    {
        public VideoPlayComplete(string trackingId)
        {
            TrackingId = trackingId;
        }
        public string TrackingId { get; }
    }
}
