namespace LineMessagingAPI
{
    public class SpanComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Span;
        public string Text { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Weight? Weight { get; set; }
        public TextStyle Style { get; set; }
        public string Decoration { get; set; }
        public SpanComponent(string text)
        {
            Text = text;
        }
        public SpanComponent()
        {

        }
    }
}
