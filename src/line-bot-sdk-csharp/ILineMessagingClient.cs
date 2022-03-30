using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LineMessagingAPI
{
    /// <summary>
    /// LINE Messaging API client, which handles request/response to LINE server.
    /// </summary>
    public interface ILineMessagingClient
    {
        #region Message 
        // https://developers.line.biz/ja/reference/messaging-api/#messages

        /// <summary>
        /// 応答メッセージを送る。
        /// Send response messages.
        /// https://developers.line.biz/ja/reference/messaging-api/#send-reply-message
        /// </summary>
        Task ReplyMessageAsync(string replyToken, IList<ISendMessage> messages, bool notificationDisabled = false);
        Task ReplyTextAsync(string replyToken, string message, Emoji[]? emojis = null, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyStickerAsync(string replyToken, string packageId, string stickerId, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyImageAsync(string replyToken, string originalContentUrl, string previewImageUrl, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyVideoAsync(string replyToken, string originalContentUrl, string previewImageUrl, string trackingId, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyAudioAsync(string replyToken, string originalContentUrl, long duration, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyLocationAsync(string replyToken, string title, string address, decimal latitude, decimal longitude, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);
        Task ReplyFlexMessageAsync(string replyToken, string altText, IFlexContainer contents, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null);


        /// <summary>
        /// プッシュメッセージを送る。
        /// Send response messages.
        /// /// https://developers.line.biz/ja/reference/messaging-api/#send-push-message
        /// </summary>
        Task PushMessageAsync(string to, IList<ISendMessage> messages, bool notificationDisabled = false, string? RetryKey = null);
        Task PushTextAsync(string to, string message, Emoji[]? emojis = null, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushStickerAsync(string to, string packageId, string stickerId, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushImageAsync(string to, string originalContentUrl, string previewImageUrl, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushVideoAsync(string to, string originalContentUrl, string previewImageUrl, string trackingId, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushAudioAsync(string to, string originalContentUrl, long duration, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushLocationAsync(string to, string title, string address, decimal latitude, decimal longitude, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);
        Task PushFlexMessageAsync(string to, string altText, IFlexContainer contents, bool notificationDisabled = false, QuickReply? quickReply = null, Sender? sender = null, string? RetryKey = null);


        /// <summary>
        /// マルチキャストメッセージを送る。
        /// Send multicast messages.
        /// https://developers.line.biz/ja/reference/messaging-api/#send-multicast-message
        /// </summary>
        /// <param name="to">IDs of the receivers. Max: 500 users</param>
        /// <param name="messages">Reply messages. Up to 5 messages.</param>
        /// <param name="notificationDisabled">Notify the user.</param>
        Task MultiCastMessageAsync(IList<string> to, IList<ISendMessage> messages, bool notificationDisabled = false, string? RetryKey = null);

        /// <summary>
        /// マルチキャストメッセージを送る。
        /// Send multicast messages.
        /// https://developers.line.biz/ja/reference/messaging-api/#send-multicast-message
        /// </summary>
        /// <param name="to">IDs of the receivers. Max: 500 users</param>
        /// <param name="notificationDisabled">Notify the user.</param>
        /// <param name="messages">Set reply messages with Json string.</param>
        Task MultiCastMessageWithJsonAsync(IList<string> to, bool notificationDisabled = false, string? RetryKey = null, params string[] messages);

        /// <summary>
        /// マルチキャストメッセージを送る。
        /// Send multicast messages.\
        /// https://developers.line.biz/ja/reference/messaging-api/#send-multicast-messages
        /// </summary>
        /// <param name="to">IDs of the receivers. Max: 500 users</param>
        /// <param name="notificationDisabled">Notify the user.</param>
        /// <param name="messages">Reply text messages. Up to 5 messages.</param>
        Task MultiCastMessageAsync(IList<string> to, bool notificationDisabled = false, string? RetryKey = null, params string[] messages);

        /// <summary>
        /// ナローキャストメッセージの進行状況を取得する
        /// Get the progress of a narrowcast message.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-narrowcast-progress-status
        /// </summary>
        /// <param name="requestId"></param>
        Task<ProgressNarrowcast> GetProgressNarrowcastAsync(string requestId);

        /// <summary>
        /// ブロードキャストキャストメッセージを送る。
        /// Send broadcast messages.
        /// https://developers.line.biz/ja/reference/messaging-api/#send-multicast-messages
        /// </summary>
        /// <param name="notificationDisabled">Notify the user.</param>
        /// <param name="messages">Reply text messages. Up to 5 messages.</param>
        Task BroadCastMessageAsync(IList<ISendMessage> messages, bool notificationDisabled = false, string? RetryKey = null);

        /// <summary>
        /// ブロードキャストキャストメッセージを送る。
        /// Send broadcast messages.
        /// https://developers.line.biz/ja/reference/messaging-api/#send-multicast-messages
        /// </summary>
        /// <param name="notificationDisabled">Notify the user.</param>
        /// <param name="messages">Reply text messages. Up to 5 messages.</param>
        Task BroadCastMessageAsync(bool notificationDisabled = false, string? RetryKey = null, params string[] messages);

        /// <summary>
        /// コンテンツを取得する
        /// Retrieving contents
        /// https://developers.line.biz/ja/reference/messaging-api/#get-content
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Content as ContentStream</returns>
        Task<ContentStream> GetContentStreamAsync(string messageId);

        /// <summary>
        /// コンテンツを取得する
        /// Retrieving contents
        /// https://developers.line.biz/ja/reference/messaging-api/#get-content
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Content as byte array</returns>
        Task<byte[]> GetContentBytesAsync(string messageId);

        /// <summary>
        /// 当月分の上限目安を取得します。
        /// Get the upper limit guideline for the current month.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-quota
        /// </summary>
        Task<Quota> GetQuota();

        /// <summary>
        /// 当月に送信されたメッセージの数を取得します。
        /// Gets the number of messages sent in the current month.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-consumption
        /// </summary>
        Task<Consumption> GetConsumption();

        /// <summary>
        /// 送信済みの応答メッセージの数を取得する。
        /// Get the number of response messages that have been sent.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-number-of-reply-messages
        /// </summary>
        Task<NumberOfMessages> GetNumberOfReplyMessages(DateTime date);

        /// <summary>
        /// 送信済みのプッシュメッセージの数を取得する。
        /// Get the number of push messages that have been sent.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-number-of-push-messages
        /// </summary>
        Task<NumberOfMessages> GetNumberOfPushMessages(DateTime date);

        /// <summary>
        /// 送信済みのマルチキャストメッセージの数を取得する。
        /// Get the number of multicast messages that have been sent.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-number-of-multicast-messages
        /// </summary>
        Task<NumberOfMessages> GetNumberOfMulticastMessages(DateTime date);

        /// <summary>
        /// 送信済みのブロードキャストメッセージの数を取得する。
        /// Get the number of broadcast messages that have been sent.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-number-of-broadcast-messages
        /// </summary>
        Task<NumberOfMessages> GetNumberOfBroadcastMessages(DateTime date);


        #endregion

        #region Profile

        /// <summary>
        /// Get user profile information.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-profile
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns></returns>
        Task<UserProfile> GetUserProfileAsync(string userId);

        #endregion

        #region Bot
        // // https://developers.line.biz/ja/reference/messaging-api/#group

        /// <summary>
        /// ボットの情報を取得する
        /// Get information about the bot.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-bot-info
        /// </summary>
        Task<BotInfo> GetBotInfo();
        #endregion

        #region Group
        // https://developers.line.biz/ja/reference/messaging-api/#group

        /// <summary>
        /// グループの概要を取得する
        /// Get an overview of the group
        /// https://developers.line.biz/ja/reference/messaging-api/#get-group-summary
        /// </summary>
        /// <param name="groupId"></param>
        Task<GroupSummary> GetGroupSummary(string groupId);

        /// <summary>
        /// グループに参加しているユーザーの人数を取得する
        /// Get the number of users participating in a group.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-members-group-count
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<MemberCount> GetGroupMemberCount(string groupId);

        /// <summary>
        /// グループメンバーのユーザーIDを取得する
        /// Get the user IDs of the group members.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-group-member-user-ids
        /// </summary>
        /// <param name="groupId">Identifier of the group</param>
        /// <param name="continuationToken">ContinuationToken</param>
        Task<GroupMemberIds> GetGroupMemberIdsAsync(string groupId, string? continuationToken = null);

        /// <summary>
        /// グループメンバーのプロフィール情報を取得する
        /// Retrieve group members' profile information
        /// https://developers.line.biz/ja/reference/messaging-api/#get-group-member-profile
        /// </summary>
        /// <param name="groupId">Identifier of the group</param>
        /// <param name="userId">Identifier of the user</param>
        Task<UserProfile> GetGroupMemberProfileAsync(string groupId, string userId);

        /// <summary>
        /// グループから退出する
        /// Leave the group.
        /// https://developers.line.biz/ja/reference/messaging-api/#leave-group
        /// </summary>
        /// <param name="groupId">Group ID</param>
        Task LeaveFromGroupAsync(string groupId);

        /// <summary>
        /// グループメンバーのプロフィール情報を取得する
        /// Retrieve group members' profile information
        /// </summary>
        /// <param name="groupId">Identifier of the group</param>
        Task<IList<UserProfile>> GetGroupMemberProfilesAsync(string groupId);

        #endregion

        #region Room

        // https://developers.line.biz/ja/reference/messaging-api/#chat-room

        /// <summary>
        /// トークルームに参加しているユーザーの人数を取得する。
        /// Get the number of users participating in a talk room.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-members-room-count
        /// </summary>
        /// <param name="userId"></param>
        Task<MemberCount> GetRoomMemberCountAsync(string roomId);

        /// <summary>
        /// トークルームメンバーのユーザーIDを取得する
        /// Get the user ID of the talk room member.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-members-room-count
        /// </summary>
        /// <param name="roomId">Identifier of the room</param>
        /// <param name="continuationToken">ContinuationToken</param>
        /// <returns>GroupMemberIds</returns>
        Task<GroupMemberIds> GetRoomMemberIdsAsync(string roomId, string? continuationToken = null);

        /// <summary>
        /// トークルームメンバーのプロフィール情報を取得する
        /// Get the profile information of a talk room member.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-room-member-profile
        /// </summary>
        /// <param name="roomId">Identifier of the room</param>
        /// <returns>List of UserProfiles</returns>
        Task<UserProfile> GetRoomMemberProfilesAsync(string roomId, string userId);

        /// <summary>
        /// トークルームから退出する
        /// Exit the talk room.
        /// https://developers.line.biz/ja/reference/messaging-api/#leave-room
        /// </summary>
        /// <param name="roomId">Room ID</param>
        Task LeaveFromRoomAsync(string roomId);

        #endregion

        #region Rich menu

        /// <summary>
        /// Gets a rich menu via a rich menu ID.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-rich-menu
        /// </summary>
        /// <param name="richMenuId">ID of an uploaded rich menu</param>
        /// <returns>RichMenu</returns>
        Task<RichMenu> GetRichMenuAsync(string richMenuId);

        /// <summary>
        /// Creates a rich menu. 
        /// Note: You must upload a rich menu image and link the rich menu to a user for the rich menu to be displayed.You can create up to 10 rich menus for one bot.
        /// The rich menu represented as a rich menu object.
        /// https://developers.line.biz/ja/reference/messaging-api/#create-rich-menu
        /// </summary>
        /// <param name="richMenu">RichMenu</param>
        /// <returns>RichMenu Id</returns>
        Task<string> CreateRichMenuAsync(RichMenu richMenu);

        /// <summary>
        /// Deletes a rich menu.
        /// https://developers.line.biz/ja/reference/messaging-api/#delete-rich-menu
        /// </summary>
        /// <param name="richMenuId">RichMenu Id</param>
        Task DeleteRichMenuAsync(string richMenuId);

        /// <summary>
        /// Gets the ID of the rich menu linked to a user.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-rich-menu-id-of-user
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <returns>RichMenu Id</returns>
        Task<string> GetRichMenuIdOfUserAsync(string userId);

        /// <summary>
        /// Sets a default ritch menu
        /// </summary>
        /// <param name="richMenuId">
        /// ID of an uploaded rich menu
        /// </param>
        Task SetDefaultRichMenuAsync(string richMenuId);

        /// <summary>
        /// Links a rich menu to a user.
        /// Note: Only one rich menu can be linked to a user at one time.
        /// https://developers.line.biz/ja/reference/messaging-api/#link-rich-menu-to-user
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <param name="richMenuId">ID of an uploaded rich menu</param>
        /// <returns></returns>
        Task LinkRichMenuToUserAsync(string userId, string richMenuId);

        /// <summary>
        /// Unlinks a rich menu from a user.
        /// https://developers.line.biz/ja/reference/messaging-api/#unlink-rich-menu-from-user
        /// </summary>
        /// <param name="userId">ID of the user</param>
        /// <returns></returns>
        Task UnLinkRichMenuFromUserAsync(string userId);

        /// <summary>
        /// Downloads an image associated with a rich menu.
        /// https://developers.line.biz/ja/reference/messaging-api/#download-rich-menu-image
        /// </summary>
        /// <param name="richMenuId">RichMenu Id</param>
        /// <returns>Image as ContentStream</returns>
        Task<ContentStream> DownloadRichMenuImageAsync(string richMenuId);

        /// <summary>
        /// Uploads and attaches a jpeg image to a rich menu.
        /// Images must have one of the following resolutions: 2500x1686, 2500x843. 
        /// You cannot replace an image attached to a rich menu.To update your rich menu image, create a new rich menu object and upload another image.
        /// https://developers.line.biz/ja/reference/messaging-api/#upload-rich-menu-image
        /// </summary>
        /// <param name="stream">Jpeg image for the rich menu</param>
        /// <param name="richMenuId">The ID of the rich menu to attach the image to.</param>
        Task UploadRichMenuJpegImageAsync(Stream stream, string richMenuId);

        /// <summary>
        /// Uploads and attaches a png image to a rich menu.
        /// Images must have one of the following resolutions: 2500x1686, 2500x843. 
        /// You cannot replace an image attached to a rich menu.To update your rich menu image, create a new rich menu object and upload another image.
        /// https://developers.line.biz/ja/reference/messaging-api/#upload-rich-menu-image
        /// </summary>
        /// <param name="stream">Png image for the rich menu</param>
        /// <param name="richMenuId">The ID of the rich menu to attach the image to.</param>
        Task UploadRichMenuPngImageAsync(Stream stream, string richMenuId);

        /// <summary>
        /// Gets a list of all uploaded rich menus.
        /// https://developers.line.biz/ja/reference/messaging-api/#get-rich-menu-list
        /// </summary>
        /// <returns>List of ResponseRichMenu</returns>
        Task<IList<ResponseRichMenu>> GetRichMenuListAsync();

        #endregion

        #region Account Link

        /// <summary>
        /// 連携トークンを発行する
        /// Issue a link token
        /// https://developers.line.biz/ja/reference/messaging-api/#issue-link-token
        /// </summary>
        /// <param name="userId">
        Task<string> IssueLinkTokenAsync(string userId);
        #endregion
    }
}
