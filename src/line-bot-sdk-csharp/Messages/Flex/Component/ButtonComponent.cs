namespace LineMessagingAPI
{
    public class ButtonComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Button;
        public ITemplateAction Action { get; set; }
        public int? Flex { get; set; }
        public string Margin { get; set; }
        public Position Position { get; set; }
        public string OffsetTop { get; set; }
        public string OffsetBottom { get; set; }
        public string OffsetStart { get; set; }
        public string OffsetEnd { get; set; }
        public string Height { get; set; }
        public ButtonStyle? Style { get; set; }
        public string Color { get; set; }
        public Gravity? Gravity { get; set; }
        public string AdjustMode { get; set; }
        public ButtonComponent(ITemplateAction action)
        {
            Action = action;
        }
        public ButtonComponent()
        {

        }
    }
}
