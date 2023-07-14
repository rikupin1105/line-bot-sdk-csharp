using System;
using System.Collections.Generic;

namespace LineMessagingAPI
{
    /// <summary>
    /// https://developers.line.biz/ja/reference/messaging-api/#rich-menu-object
    /// https://developers.line.biz/en/reference/messaging-api/#rich-menu-object
    /// </summary>
    public class RichMenu
    {
        /// <summary>
        /// size object which contains the width and height of the rich menu displayed in the chat. Rich menu images must be one of the following sizes: 2500x1686, 2500x843.
        /// </summary>
        public ActionSize Size { get; set; }

        /// <summary>
        /// true to display the rich menu by default. Otherwise, false.
        /// </summary>
        public bool Selected { set; get; }

        /// <summary>
        /// Name of the rich menu. This value can be used to help manage your rich menus and is not displayed to users. Maximum of 300 characters.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Text displayed in the chat bar. Maximum of 14 characters.
        /// </summary>
        public string ChatBarText { get; set; }

        /// <summary>
        /// Array of area objects which define the coordinates and size of tappable areas. Maximum of 20 area objects.
        /// </summary>
        public IList<ActionArea> Areas { set; get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="selected"></param>
        /// <param name="name"></param>
        /// <param name="chatBarText"></param>
        /// <param name="areas"></param>
        public RichMenu(ActionSize size, bool selected, string name, string chatBarText, IList<ActionArea> areas)
        {
            Size = size;
            Selected = selected;
            Name = name[..Math.Min(name.Length, 300)];
            ChatBarText = chatBarText[..Math.Min(chatBarText.Length, 14)];
            Areas = areas;
        }

        /// <summary>
        /// Converts from RichMenu to ResponseRichMenu
        /// </summary>
        /// <param name="richMenuId">
        /// Rich menu ID
        /// </param>
        /// <returns>ResponseRichMenu object</returns>
        public ResponseRichMenu ToResponseRichMenu(string richMenuId = "")
        {
            return new ResponseRichMenu(richMenuId, this);
        }
    }
}
