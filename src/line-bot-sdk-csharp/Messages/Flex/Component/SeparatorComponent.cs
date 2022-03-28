namespace LineMessagingAPI
{
    public class SeparatorComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Separator;
        public string Margin { get; set; }
        public string Color { get; set; }
    }
}
