namespace LineMessagingAPI
{
    public interface ITemplateAction
    {
        TemplateActionType Type { get; }
        string Label { get; }
    }
}
