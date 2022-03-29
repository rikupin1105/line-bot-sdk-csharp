using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// This is a component that defines the layout of child components. You can also include a box in a box.
    /// </summary>
    public class BoxComponent : IFlexComponent
    {
        public BoxComponent(BoxLayout layout)
        {
            Layout = layout;
        }
        public BoxComponent() { }
        public FlexComponentType Type => FlexComponentType.Box;
        public BoxLayout Layout { get; set; }
        public IList<IFlexComponent> Contents { get; set; } = new List<IFlexComponent>();
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public string BorderWidth { get; set; }
        public string CornerRadius { get; set; }
        public string Width { get; set; }
        public string MaxWidth { get; set; }
        public string Height { get; set; }
        public string MaxHeight { get; set; }
        public int? Flex { get; set; }
        public string Spacing { get; set; }
        public string Margin { get; set; }
        public string PaddingAll { get; set; }
        public string PaddingTop { get; set; }
        public string PaddingBottom { get; set; }
        public string PaddingStart { get; set; }
        public string PaddingEnd { get; set; }
        public Position? Position { get; set; }
        public string OffsetTop { get; set; }
        public string OffsetBottom { get; set; }
        public string OffsetStart { get; set; }
        public string OffsetEnd { get; set; }
        public ITemplateAction Action { get; set; }
        public string JustifyContent { get; set; }
        public string AlignItems { get; set; }
        public Background Background { get; set; }
    }
}
