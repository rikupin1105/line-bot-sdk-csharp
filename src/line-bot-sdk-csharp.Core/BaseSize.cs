namespace LineMessagingAPI.Core
{
    public class BaseSize
    {
        /// <summary>
        /// Width
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Height
        /// </summary>
        public int Height { get; }

        public BaseSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}

