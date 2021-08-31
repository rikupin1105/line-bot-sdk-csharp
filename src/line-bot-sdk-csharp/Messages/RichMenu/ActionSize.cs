namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#size-object
    /// https://developers.line.biz/en/reference/messaging-api/#size-object
    /// </summary>
    public class ActionSize
    {
        /// <summary>
        /// Width of the rich menu. Must be 2500.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Height of the rich menu. Possible values: 1686, 843.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public ActionSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}