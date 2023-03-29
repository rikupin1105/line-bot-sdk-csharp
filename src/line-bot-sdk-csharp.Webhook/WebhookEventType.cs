namespace LineMessagingAPI.Webhook
{
    /// <summary>
    /// Webhook Event Type
    /// </summary>
    public enum WebhookEventType
    {
        Message,
        Unsend,
        Follow,
        Unfollow,
        Join,
        Leave,
        Postback,
        VideoPlayComplete,
        Beacon,
        AccountLink,
        MemberJoined,
        MemberLeft,
        Things
    }
}
