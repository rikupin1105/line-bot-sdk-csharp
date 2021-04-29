using System;
using System.Collections.Generic;

namespace LineMessagingAPI.Webhooks
{
    /// <summary>
    /// Contents of the message
    /// </summary>
    public class EventMessage
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// EventMessageType
        /// </summary>
        public EventMessageType Type { get; }

        public EventMessage(EventMessageType type, string id)
        {
            Type = type;
            Id = id;
        }

        internal static EventMessage CreateFrom(dynamic dynamicObject)
        {
            var message = dynamicObject?.message;
            if (message == null) { return null; }
            if (!Enum.TryParse((string)message.type, true, out EventMessageType messageType))
            {
                return null;
            }
            switch (messageType)
            {
                case EventMessageType.Text:
                    var emojis_list = new List<Emoji>();
                    var mentionees_list = new List<Mentionees>();

                    try
                    {
                        for (int i = 0; i < message.emojis.Count; i++)
                        {
                            var emoji = new Emoji(
                                (int)message.emojis[i]?.index,
                                (int)message.emojis[i]?.length,
                                (string)message.emojis[i]?.productId,
                                (string)message.emojis[i]?.emojiId);
                            emojis_list.Add(emoji);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        for (int i = 0; i < message.mention.mentionees.Count; i++)
                        {
                            var mentionees = new Mentionees(
                                (int)message.mention.mentionees[i]?.index,
                                (int)message.mention.mentionees[i]?.length,
                                (string)message.mention.mentionees[i]?.userId);
                            mentionees_list.Add(mentionees);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    var emojis = emojis_list.ToArray();
                    var mention = new Mention(mentionees_list.ToArray());

                    return new TextEventMessage(
                        (string)message.id,
                        (string)message.text,
                        emojis,
                        mention);

                case EventMessageType.Image:
                case EventMessageType.Audio:
                case EventMessageType.Video:
                    ContentProvider contentProvider = null;
                    if (Enum.TryParse((string)message.contentProvider?.type, true, out ContentProviderType providerType))
                    {
                        contentProvider = new ContentProvider(providerType,
                                (string)message.contentProvider?.originalContentUrl,
                                (string)message.contentProvider?.previewContentUrl);
                    }
                    return new MediaEventMessage(
                        messageType,
                        (string)message.id,
                        contentProvider,
                        (int?)message.duration);

                case EventMessageType.Location:
                    return new LocationEventMessage(
                        (string)message.id,
                        (string)message.title,
                        (string)message.address,
                        (decimal)message.latitude,
                        (decimal)message.longitude);

                case EventMessageType.Sticker:
                    var keywords_list = new List<string>();
                    try
                    {
                        for (int i = 0; i < message.keywords.Count; i++)
                        {
                            keywords_list.Add((string)message.keywords[i]);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    return new StickerEventMessage(
                        (string)message.id,
                        (string)message.packageId,
                        (string)message.stickerId,
                        keywords_list.ToArray(),
                        (StickerResourceType)message.stickerResourceType);

                case EventMessageType.File:
                    return new FileEventMessage(
                        (string)message.id,
                        (string)message.fileName,
                        (long)message.fileSize);
                default:
                    return null;
            }
        }
    }
}
