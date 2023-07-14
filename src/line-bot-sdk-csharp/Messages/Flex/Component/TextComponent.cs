using System.Collections.Generic;

namespace LineMessagingAPI
{
    public class TextComponent : IFlexComponent
    {
        public FlexComponentType Type => FlexComponentType.Text;
        public string Text { get; set; }
        public IList<SpanComponent> Contents { get; set; }
        public string AdjustMode { get; set; }
        public int? Flex { get; set; }
        public string Margin { get; set; }
        public Position? Position { get; set; }
        public string OffsetTop { get; set; }
        public string OffsetBottom { get; set; }
        public string OffsetStart { get; set; }
        public string OffsetEnd { get; set; }
        public string Size { get; set; }
        public bool? Scalling { get; set; }
        public Align? Align { get; set; }
        public Gravity? Gravity { get; set; }
        public bool? Wrap { get; set; }
        public string LineSpacing { get; set; }
        public int? MaxLines { get; set; }
        public Weight? Weight { get; set; }
        public string Color { get; set; }
        public ITemplateAction Action { get; set; }
        public TextStyle? Style { get; set; }
        public string Decoration { get; set; }
        public TextComponent(string text)
        {
            Text = text;
        }
        public TextComponent()
        {

        }
    }
}
