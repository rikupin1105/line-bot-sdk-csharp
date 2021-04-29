﻿namespace LineMessagingAPI
{
    /// <summary>
    /// Defines the size of a tappable area. The top left is used as the origin of the area.
    /// https://developers.line.me/en/docs/messaging-api/reference/#imagemap-area-object
    /// </summary>
    public class ImagemapArea
    {
        /// <summary>
        /// Horizontal position relative to the top-left corner of the area.
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Vertical position relative to the top-left corner of the area.
        /// </summary>
        public int Y { get; }
        /// <summary>
        /// Width of the tappable area
        /// </summary>
        public int Width { get; }
        /// <summary>
        /// Height of the tappable area
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">
        /// Horizontal position relative to the top-left corner of the area.
        /// </param>
        /// <param name="y">
        /// Vertical position relative to the top-left corner of the area.
        /// </param>
        /// <param name="width">
        /// Width of the tappable area
        /// </param>
        /// <param name="height">
        /// Height of the tappable area
        /// </param>
        public ImagemapArea(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
