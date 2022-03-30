namespace LineMessagingAPI
{
    public interface ISendMessage
    {
        MessageType Type { get; }
        QuickReply? QuickReply { get; set; }
        Sender? Sender { get; set; }
    }
}
