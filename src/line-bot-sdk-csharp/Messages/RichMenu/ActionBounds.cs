namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#bounds-object
    /// https://developers.line.biz/en/reference/messaging-api/#bounds-object
    /// </summary>
    public class ActionBounds
    {
        /// <summary>
        /// Horizontal position of the top-left corner of the tappable area relative to the left edge of the image. Value must be 0 or higher.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Vertical position of the top-left corner of the tappable area relative to the left edge of the image. Value must be 0 or higher.
        /// </summary>
        public int Y {  get; set; }
        /// <summary>
        /// Width of the tappable area.
        /// </summary>
        public int Width {  get; set; }
        /// <summary>
        /// Height of the tappable area.
        /// </summary>
        public int Height {  get; set; }
        /// <summary>
        /// Contstuctor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public ActionBounds(int x,int y,int width,int height)
        {
            X = x;
            Y = y;  
            Width = width;  
            Height = height;
        }
    }
}