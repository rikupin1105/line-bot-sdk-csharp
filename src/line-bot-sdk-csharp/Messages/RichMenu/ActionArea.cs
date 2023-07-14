namespace LineMessagingAPI
{
    /// <summary>
    /// Rich menu  Area
    /// https://developers.line.biz/ja/reference/messaging-api/#area-object
    /// </summary>
    public class ActionArea
    {
        /// <summary>
        /// Object describing the boundaries of the area in pixels. See bounds object.
        /// </summary>
        public ActionBounds Bounds { get; set; }

        /// <summary>
        /// Action performed when the area is tapped. See action objects. Note: The label field is not supported for actions in rich menus.
        /// </summary>
        public ITemplateAction Action { get; set; }

        public ActionArea(dynamic dynamicObject)
        {
            Bounds = new ActionBounds(
                (int)(dynamicObject?.bounds?.x ?? 0),
                (int)(dynamicObject?.bounds?.y ?? 0),
                (int)(dynamicObject?.bounds?.width ?? 0),
                (int)(dynamicObject?.bounds?.height ?? 0));

            Action = ParseTemplateAction(dynamicObject?.action);
        }

        public static ITemplateAction ParseTemplateAction(dynamic dynamicObject)
        {
            var type = (TemplateActionType)System.Enum.Parse(typeof(TemplateActionType), (string)dynamicObject?.type, true);
            return type switch
            {
                TemplateActionType.Message => MessageTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.Uri => UriTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.Postback => PostbackTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.Datetimepicker => DateTimePickerTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.Camera => CameraTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.CameraRoll => CameraRollTemplateAction.CreateFrom(dynamicObject),
                TemplateActionType.Location => LocationTemplateAction.CreateFrom(dynamicObject),
                _ => throw new System.Exception(),
            };
        }
    }
}