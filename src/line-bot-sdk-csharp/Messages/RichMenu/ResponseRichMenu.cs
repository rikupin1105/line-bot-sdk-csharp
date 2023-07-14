using System.Collections.Generic;
using System.Linq;

namespace LineMessagingAPI
{
    /// <summary>
    /// Rich menu response object.
    /// https://developers.line.me/en/docs/messaging-api/reference/#rich-menu-response-object
    /// </summary>
    public class ResponseRichMenu : RichMenu
    {
        /// <summary>
        /// Rich menu ID
        /// </summary>
        public string RichMenuId { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="richMenuId"></param>
        /// <param name="source"></param>
        public ResponseRichMenu(string richMenuId, RichMenu source) : base(source.Size, source.Selected, source.Name, source.ChatBarText, source.Areas)
        {
            RichMenuId = richMenuId;
        }

        internal static ResponseRichMenu CreateFrom(dynamic dynamicObject)
        {
            if (dynamicObject == null)
            {
                throw new System.NullReferenceException();
            }

            var areas = new List<ActionArea>();
            foreach (var area in dynamicObject.areas ?? Enumerable.Empty<dynamic>())
            {
                areas.Add(ActionArea.CreateFrom(area));
            }

            var menu = new RichMenu(
                new ActionSize((int)(dynamicObject.size?.width ?? 0),  (int)(dynamicObject.size?.height ?? 0)),
                (bool)(dynamicObject.selected ?? false),
                (string)dynamicObject.name, 
                (string)dynamicObject.chatBarText, 
                areas);

            return new ResponseRichMenu((string)dynamicObject.richMenuId, menu);
        }
    }
}
