using System;
using System.Collections.Generic;

namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// The webhook event generated on the LINE Platform.
    /// https://developers.line.biz/ja/reference/messaging-api/#common-properties
    /// </summary>
    public abstract class WebhookEvent
    {
        /// <summary>
        /// Identifier for the type of event
        /// </summary>
        public WebhookEventType Type { get; }

        /// <summary>
        /// channel status
        /// </summary>
        public string Mode { get; }

        /// <summary>
        /// Time of the event in milliseconds
        /// </summary>
        public long Timestamp { get; }

        /// <summary>
        /// JSON object which contains the source of the event
        /// </summary>
        public WebhookEventSource Source { get; }

        public string WebhookEventId { get; }
        public DeliveryContext DeliveryContext { get; }

        public WebhookEvent(WebhookEventType type, WebhookEventSource source, long timestamp, string mode, string webhookEventId, DeliveryContext deliveryContext)
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Mode = mode;
            WebhookEventId = webhookEventId;
            DeliveryContext = deliveryContext;
        }

        internal static WebhookEvent CreateFrom(dynamic dynamicObject)
        {
            if (dynamicObject is null) { throw new ArgumentNullException(nameof(dynamicObject)); }

            var eventSource = WebhookEventSource.CreateFrom(dynamicObject?.source);

            if (eventSource is null)
            {
                return null;
            }
            if (!Enum.TryParse((string)dynamicObject.type, true, out WebhookEventType eventType))
            {
                return null;
            }

            switch (eventType)
            {
                case WebhookEventType.Message:
                    EventMessage eventMessage = EventMessage.CreateFrom(dynamicObject);
                    if (eventMessage is null) { return null; }
                    return new MessageEvent(eventSource, (long)dynamicObject.timestamp, eventMessage, (string)dynamicObject.replyToken, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Unsend:
                    var unsend = new Unsend((string)dynamicObject.unsend?.messageId);
                    return new UnsendEvent(eventSource, (long)dynamicObject.timestamp,
                        (string)dynamicObject.mode, unsend, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Follow:
                    return new FollowEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Unfollow:
                    return new UnfollowEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Join:
                    return new JoinEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Leave:
                    return new LeaveEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Postback:
                    var postback = new Postback(
                        (string)dynamicObject.postback?.data,
                        (string)dynamicObject.postback?.@params?.date,
                        (string)dynamicObject.postback?.@params?.time,
                        (string)dynamicObject.postback?.@params?.datetime);
                    return new PostbackEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken, postback, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.VideoPlayComplete:
                    var videoPlayComplete = new VideoPlayComplete((string)dynamicObject.videoPlayComplete?.trackingId);
                    return new VideoViewingCompleteEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.mode, (string)dynamicObject.replyToken, videoPlayComplete, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Beacon:
                    if (!Enum.TryParse((string)dynamicObject.beacon.type, true, out BeaconType beaconType))
                    {
                        return null;
                    }
                    return new BeaconEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken,
                        (string)dynamicObject.beacon.hwid, beaconType, (string)dynamicObject.beacon.dm, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.AccountLink:
                    var link = new Link((string)dynamicObject.link?.result, (string)dynamicObject.link?.nonce);
                    return new AccountLinkEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken, link, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.Things:
                    var thingsType = (ThingsType)Enum.Parse(typeof(ThingsType), (string)dynamicObject.things?.type, true);
                    var things = new Things((string)dynamicObject.things?.deviceId, thingsType);
                    return DeviceEvent.Create(eventSource, (long)dynamicObject.timestamp, things, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));

                case WebhookEventType.MemberJoined:

                    var joinedMembers = new List<WebhookEventSource>();
                    foreach (var member in dynamicObject.joined.members)
                    {
                        joinedMembers.Add(WebhookEventSource.CreateFrom(member));
                    }
                    return new MemberJoinEvent(eventSource, (long)dynamicObject.timestamp, (string)dynamicObject.replyToken, joinedMembers, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));


                case WebhookEventType.MemberLeft:
                    var leftMembers = new List<WebhookEventSource>();
                    foreach (var member in dynamicObject.left.members)
                    {
                        leftMembers.Add(WebhookEventSource.CreateFrom(member));
                    }
                    return new MemberLeaveEvent(eventSource, (long)dynamicObject.timestamp, leftMembers, (string)dynamicObject.mode, (string)dynamicObject.webhookEventId, new DeliveryContext((bool)dynamicObject.deliveryContext.isRedelivery));
                default:
                    return null;
            }
        }
    }
}
