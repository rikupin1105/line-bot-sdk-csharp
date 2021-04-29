using System;

namespace LineMessagingAPI
{
    /// <summary>
    /// Provide URLs of the LINE URL scheme.
    /// <para>https://developers.line.me/ja/docs/messaging-api/using-line-url-scheme/</para> 
    /// </summary>
    public static class LineSchemeUrl
    {
        private static readonly string camera = "https://line.me/R/nv/camera/";
        private static readonly string cameraRollSingle = "https://line.me/R/nv/cameraRoll/single";
        private static readonly string cameraRollMulti = "https://line.me/R/nv/cameraRoll/multi";
        private static readonly string location = "https://line.me/R/nv/location";
        private static readonly string tiP = "https://line.me/R/ti/p/{0}";
        private static readonly string recommendOA = "https://line.me/R/nv/recommendOA/{0}";
        private static readonly string homePublicMain = "https://line.me/R/home/public/main?id={0}";
        private static readonly string homePublicProfile = "https://line.me/R/home/public/profile?id={0}";
        private static readonly string homePublicPost = "https://line.me/R/home/public/post?id={0}&postId={1}";
        private static readonly string msgText = "https://line.me/R/msg/text/?{0}";
        private static readonly string oaMessage = "https://line.me/R/oaMessage/{0}/?{1}";
        private static readonly string profile = "https://line.me/R/nv/profile";
        private static readonly string profileSetId = "https://line.me/R/nv/profileSetId";
        private static readonly string chat = "https://line.me/R/nv/chat";
        private static readonly string timeline = "https://line.me/R/nv/timeline";
        private static readonly string more = "https://line.me/R/nv/more";
        private static readonly string addFriends = "https://line.me/R/nv/addFriends";
        private static readonly string officialAccounts = "https://line.me/R/nv/officialAccounts";
        private static readonly string settings = "https://line.me/R/nv/settings";
        private static readonly string settingsAccount = "https://line.me/R/nv/settings/account";
        private static readonly string connectedApps = "https://line.me/R/nv/connectedApps";
        private static readonly string connectedDevices = "https://line.me/R/nv/connectedDevices";
        private static readonly string settingsPrivacy = "https://line.me/R/nv/settings/privacy";
        private static readonly string thingsDevicesLink = "https://line.me/R/nv/things/deviceLink";
        private static readonly string settingsSticker = "https://line.me/R/nv/settings/sticker";
        private static readonly string stickerShopMySticker = "https://line.me/R/nv/stickerShop/mySticker";
        private static readonly string settingsThemeIos = "https://line.me/R/nv/themeSettingsMenu";
        private static readonly string settingsThemeAndroid = "https://line.me/R/nv/settings/theme";
        private static readonly string themeSettings = "https://line.me/R/nv/themeSettings";
        private static readonly string notificationsServiceDetail = "https://line.me/R/nv/notificationServiceDetail";
        private static readonly string settingsChatSettings = "https://line.me/R/nv/settings/chatSettings";
        private static readonly string suggestSettings = "https://line.me/R/nv/suggestSettings";
        private static readonly string settingsCallSettings = "https://line.me/R/nv/settings/callSettings";
        private static readonly string settingsAddressBookSync = "https://line.me/R/nv/settings/addressBookSync";
        private static readonly string settingsTimelineSettings = "https://line.me/R/nv/settings/timelineSettings";
        private static readonly string shopStickerDetail = "https://line.me/R/shop/sticker/detail/{0}";
        private static readonly string shopCategory = "https://line.me/R/shop/category/{0}";
        private static readonly string shopStickerAuthor = "https://line.me/R/shop/sticker/author/{0}";
        private static readonly string stickerShop = "https://line.me/R/nv/stickerShop";
        private static readonly string shopStikerHot = "https://line.me/R/shop/sticker/hot";
        private static readonly string shopStickerNew = "https://line.me/R/shop/sticker/new";
        private static readonly string shopStickerEvent = "https://line.me/R/shop/sticker/event";
        private static readonly string shopStickerCategory = "https://line.me/R/shop/sticker/category";
        private static readonly string call = "https://line.me/R/call/{0}/{1}";
        private static readonly string calls = "https://line.me/R/calls";
        private static readonly string callDialpad = "https://line.me/R/call/dialpad";
        private static readonly string callSettings = "https://line.me/R/call/settings";
        private static readonly string callContacts = "https://line.me/R/call/contacts";
        private static readonly string callRedeem = "https://line.me/R/call/redeem";

        /// <summary>
        /// Opens the camera screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>z
        public static string GetCameraUrl() => camera;

        /// <summary>
        /// Opens the camera screen.
        /// </summary>
        /// <param name="label">Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCameraUriTemplateAction(string label) => new UriTemplateAction(label, GetCameraUrl());

        /// <summary>
        /// Opens the "Camera Roll" screen where users can select one image to share in the chat.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetCameraRollSingleUrl() => cameraRollSingle;

        /// <summary>
        /// Opens the "Camera Roll" screen where users can select one image to share in the chat.
        /// </summary>
        /// <param name="label">Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCameraRollSingleUriTemplateAction(string label) => new UriTemplateAction(label, GetCameraRollSingleUrl());

        /// <summary>
        /// Opens the "Camera Roll" screen where users can select multiple images to share in the chat.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetCameraRollMultiUrl() => cameraRollMulti;

        /// <summary>
        /// Opens the "Camera Roll" screen where users can select multiple images to share in the chat.
        /// </summary>
        /// <param name="label">Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCameraRollMultiUriTemplateAction(string label) => new UriTemplateAction(label, GetCameraRollMultiUrl());

        /// <summary>
        /// Opens the "Location" screen. Users can share the current location or drop a pin on the map to select the location they want to share.
        /// </summary>
        /// <para>
        /// Note: This scheme is only supported in one-on-one chats between a user and a bot(LINE@ account). 
        /// Not supported on external apps or other types of LINE chats.
        ///</para>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetLocationUrl() => location;

        /// <summary>
        /// Opens the "Location" screen. Users can share the current location or drop a pin on the map to select the location they want to share.
        /// </summary>
        /// <para>
        /// Note: This scheme is only supported in one-on-one chats between a user and a bot(LINE@ account). 
        /// Not supported on external apps or other types of LINE chats.
        /// </para>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetLocationUriTemplateAction(string label) => new UriTemplateAction(label, GetLocationUrl());

        /// <summary>
        /// Opens one of the following screens depending on the user's friendship status with the bot.<para>
        /// Friend of bot: Opens the chat with the bot.</para><para>
        /// Not a friend or blocked by user: Opens the "Add friend" screen for your bot.</para>
        /// </summary>
        /// <para>https://ti/p/{LINE_Id}</para>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager. Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetTiPUrl(string lineId) => string.Format(tiP, lineId);

        /// <summary>
        /// Opens one of the following screens depending on the user's friendship status with the bot.<para>
        /// Friend of bot: Opens the chat with the bot.</para><para>
        /// Not a friend or blocked by user: Opens the "Add friend" screen for your bot.</para>
        /// </summary>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager. Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetTiPUriTemplateAction(string label, string lineId)
            => new UriTemplateAction(label, GetTiPUrl(lineId));

        /// <summary>
        /// Opens the "Share with" screen where users can select friends, groups, or chats to share a link to your bot.
        /// </summary>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager. Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetRecommendOAUrl(string lineId) => string.Format(recommendOA, lineId);

        /// <summary>
        /// Opens the "Share with" screen where users can select friends, groups, or chats to share a link to your bot.
        /// </summary>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager. Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetRemommendOAUriTemplateAction(string label, string lineId) => new UriTemplateAction(label, GetRecommendOAUrl(lineId));

        /// <summary>
        /// Opens the Timeline screen for your bot.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetHomePublicMainUrl(string lineIdWithoutAt) => string.Format(homePublicMain, lineIdWithoutAt);

        /// <summary>
        /// Opens the Timeline screen for your bot.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetHomePublicMainUriTemplateAction(string label, string lineIdWithoutAt) => new UriTemplateAction(label, GetHomePublicMainUrl(lineIdWithoutAt));

        /// <summary>
        /// Opens the account page for your bot.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetHomePublicProfileUrl(string lineIdWithoutAt) => string.Format(homePublicProfile, lineIdWithoutAt);

        /// <summary>
        /// Opens the account page for your bot.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetHomePublicProfileUriTemplateAction(string label, string lineIdWithoutAt) => new UriTemplateAction(label, GetHomePublicProfileUrl(lineIdWithoutAt));

        /// <summary>
        /// Opens a specific Timeline post for your bot. 
        /// You can find the post ID of individual posts in the "Timeline (Home)" section of the LINE@ Manager.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <param name="postId">post ID</param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetHomePublicPostUrl(string lineIdWithoutAt, string postId) => string.Format(homePublicPost, lineIdWithoutAt, postId);

        /// <summary>
        /// Opens a specific Timeline post for your bot. 
        /// You can find the post ID of individual posts in the "Timeline (Home)" section of the LINE@ Manager.
        /// </summary>
        /// <param name="lineIdWithoutAt">
        /// Do not include the "@" symbol in the LINE ID.Find the LINE ID of your bot on the LINE@ Manager.
        /// </param>
        /// <param name="postId">post ID</param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetHomePublicPostUriTemplateAction(string label, string lineIdWithoutAt, string postId) => new UriTemplateAction(label, GetHomePublicPostUrl(lineIdWithoutAt, postId));

        /// <summary>
        /// Opens the "Share with" screen where users can select friends, groups, or chats to send a preset text message.<para> 
        /// Users can also post the message as a note in a chat or post the message to Timeline.</para>
        /// </summary>
        /// <param name="textMessage"></param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetMsgTextUrl(string textMessage) => string.Format(msgText, Uri.EscapeUriString(textMessage));

        /// <summary>
        /// Opens the "Share with" screen where users can select friends, groups, or chats to send a preset text message.<para> 
        /// Users can also post the message as a note in a chat or post the message to Timeline.</para>
        /// </summary>
        /// <param name="textMessage">Text message</param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetMsgTextUriTemplateAction(string label, string textMessage) => new UriTemplateAction(label, GetMsgTextUrl(textMessage));

        /// <summary>
        /// Opens a chat screen with the bot account with a preset text message that the user can send to your bot.
        /// </summary>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager.Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <param name="textMessage">Text message</param>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetOAMessageUrl(string lineId, string textMessage) => string.Format(oaMessage, lineId, textMessage);

        /// <summary>
        /// Opens a chat screen with the bot account with a preset text message that the user can send to your bot.
        /// </summary>
        /// <param name="lineId">
        /// Find the LINE ID of your bot on the LINE@ Manager.Make sure you include the "@" symbol in the LINE ID.
        /// </param>
        /// <param name="textMessage">Text message</param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetOAMessageUriTemplateAction(string label, string lineId, string textMessage)
            => new UriTemplateAction(label, GetOAMessageUrl(lineId, textMessage));

        /// <summary>
        /// Opens the "My profile" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetProfileUrl() => profile;

        /// <summary>
        /// Opens the "My profile" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetProfileUriTemplateAction(string label) => new UriTemplateAction(label, GetProfileUrl());

        /// <summary>
        /// Opens the "LINE ID" screen where users can set a LINE ID if they have not already done so.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetProfileSetIdUrl() => profileSetId;

        /// <summary>
        /// Opens the "LINE ID" screen where users can set a LINE ID if they have not already done so.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetProfileSetIdUriTemplateAction(string label) => new UriTemplateAction(label, GetProfileSetIdUrl());

        /// <summary>
        /// Opens the "Chats" screen. 
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetChatUrl() => chat;

        /// <summary>
        /// Opens the "Chats" screen. 
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetChatUriTemplateAction(string label) => new UriTemplateAction(label, GetChatUrl());

        /// <summary>
        /// Opens the "Timeline" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetTimelineUrl() => timeline;

        /// <summary>
        /// Opens the "Timeline" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetTimelineUriTemplateAction(string label) => new UriTemplateAction(label, GetTimelineUrl());

        /// <summary>
        /// Opens the More screen. This is the screen that is opened when the tab on the furthest right is tapped. 
        /// The More tab may be represented by either the "More" label or the "..." icon depending on the user's theme.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetMoreUrl() => more;

        /// <summary>
        /// Opens the More screen. This is the screen that is opened when the tab on the furthest right is tapped. <para>
        /// The More tab may be represented by either the "More" label or the "..." icon depending on the user's theme.</para>
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetMoreUriTemplateAction(string label) => new UriTemplateAction(label, GetMoreUrl());

        /// <summary>
        /// Opens the "Add friends" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetAddFriendsUrl() => addFriends;

        /// <summary>
        /// Opens the "Add friends" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetAddFriendsUriTemplateAction(string label) => new UriTemplateAction(label, GetAddFriendsUrl());

        /// <summary>
        /// Opens the "Official Accounts" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetOfficialAccountsUrl() => officialAccounts;

        /// <summary>
        /// Opens the "Official Accounts" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetOfficialAccountsUriTemplateAction(string label) => new UriTemplateAction(label, GetOfficialAccountsUrl());

        /// <summary>
        /// Opens the "Settings" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetSettingsUrl() => settings;
        /// <summary>
        /// Opens the "Settings" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsUrl());

        /// <summary>
        /// Opens the "Account" settings screen. Displays the user's LINE account information.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetSettingsAccountUrl() => settingsAccount;

        /// <summary>
        /// Opens the "Account" settings screen. Displays the user's LINE account information.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsAccountUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsAccountUrl());

        /// <summary>
        /// Opens the "Authorized apps" screen in the "Account" settings screen.<para> 
        /// Users can see the permissions granted to authorized apps and deauthorize apps from this screen.</para>
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetConnectedAppsUrl() => connectedApps;

        /// <summary>
        /// Opens the "Authorized apps" screen in the "Account" settings screen.<para> 
        /// Users can see the permissions granted to authorized apps and deauthorize apps from this screen.</para>
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetConnectedAppsUriTemplateAction(string label) => new UriTemplateAction(label, GetConnectedAppsUrl());

        /// <summary>
        /// Opens the "Devices" screen in the "Account" settings screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetConnectedDevicesUrl() => connectedDevices;

        /// <summary>
        /// Opens the "Devices" screen in the "Account" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetConnectedDevicesUriTemplateAction(string label) => new UriTemplateAction(label, GetConnectedDevicesUrl());

        /// <summary>
        /// Opens the "Privacy" screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetSettingsPrivacyUrl() => settingsPrivacy;

        /// <summary>
        /// Opens the "Privacy" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsPrivacyUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsPrivacyUrl());

        /// <summary>
        /// Opens the "Friends" settings screen.
        /// </summary>
        /// <returns>String of LINE Scheme URL</returns>
        public static string GetSettingsAddressBooKSyncUrl() => settingsAddressBookSync;

        /// <summary>
        /// Opens the "Friends" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsAddressBooKSyncUriTemplateAction(string label)
            => new UriTemplateAction(label, GetSettingsAddressBooKSyncUrl());

        /// <summary>
        /// Opens the "Stickers" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsStickerUrl() => settingsSticker;

        /// <summary>
        /// Opens the "Stickers" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsStickerUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsStickerUrl());

        /// <summary>
        /// Opens the "My Stickers" screen in the "Stickers" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetStickerShopMyStickerUrl() => stickerShopMySticker;

        /// <summary>
        /// Opens the "My Stickers" screen in the "Stickers" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetStickerShopMyStickerUriTemplateAction(string label) => new UriTemplateAction(label, GetStickerShopMyStickerUrl());

        /// <summary>
        /// (For iOS) Opens the "Themes" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsThemeIosUrl() => settingsThemeIos;

        /// <summary>
        /// (For Android) Opens the "Themes" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsThemeIosUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsThemeIosUrl());

        /// <summary>
        /// (Android only) Opens the "Themes" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsThemeAndroidUrl() => settingsThemeAndroid;

        /// <summary>
        /// (Android only) Opens the "Themes" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsThemeAndroidUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsThemeAndroidUrl());

        /// <summary>
        /// Opens the "My Themes" screen in the "Themes" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetThemeSettingsUrl() => themeSettings;

        /// <summary>
        /// Opens the "My Themes" screen in the "Themes" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetThemeSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetThemeSettingsUrl());

        /// <summary>
        /// Opens the "Authorized apps" screen in the "Notification" settings. 
        /// Users can configure notification settings for authorized apps in this screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetNotificationsServiceDetailUrl() => notificationsServiceDetail;

        /// <summary>
        /// Opens the "Authorized apps" screen in the "Notification" settings. 
        /// Users can configure notification settings for authorized apps in this screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetNotificationsServiceDetailUriTemplateAction(string label) => new UriTemplateAction(label, GetNotificationsServiceDetailUrl());

        /// <summary>
        /// Opens the "Chats" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsChatSettingsUrl() => settingsChatSettings;

        /// <summary>
        /// Opens the "Chats" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsChatSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsChatSettingsUrl());

        /// <summary>
        /// Opens the "Display suggestions" settings screen. This screen is in the "Chats" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSuggestSettingsUrl() => suggestSettings;

        /// <summary>
        /// Opens the "Display suggestions" settings screen. This screen is in the "Chats" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSuggestSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetSuggestSettingsUrl());

        /// <summary>
        /// Opens the "Calls" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsCallSettingsUrl() => settingsCallSettings;

        /// <summary>
        /// Opens the "Calls" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsCallSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsCallSettingsUrl());

        /// <summary>
        /// Opens the "Timeline" settings screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetSettingsTimelineSettingsUrl() => settingsTimelineSettings;

        /// <summary>
        /// Opens the "Timeline" settings screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetSettingsTimelineSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetSettingsTimelineSettingsUrl());

        /// <summary>
        /// Opens the "Sticker set info" screen for a specified sticker set.
        /// </summary>
        /// <param name="packageId">
        /// Find the "package ID" in the URL of sticker set pages in the "Official stickers" section of the LINE STORE.
        /// </param>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStickerDetailUrl(string packageId) => string.Format(shopStickerDetail, packageId);

        /// <summary>
        /// Opens the "Sticker set info" screen for a specified sticker set.
        /// </summary>
        /// <param name="packageId">
        /// Find the "package ID" in the URL of sticker set pages in the "Official stickers" section of the LINE STORE.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStickerDetailUriTemplateAction(string label, string packageId)
            => new UriTemplateAction(label, GetShopStickerDetailUrl(packageId));

        /// <summary>
        /// Opens the "RANK" tab for a specified category. 
        /// Find the "category ID" in the URL of category pages in the "Official stickers" section of the LINE STORE.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopCategoryUrl(string categoryId) => string.Format(shopCategory, categoryId);

        /// <summary>
        /// Opens the "RANK" tab for a specified category. 
        /// Find the "category ID" in the URL of category pages in the "Official stickers" section of the LINE STORE.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopCategoryUriTemplateAction(string label, string categoryId)
            => new UriTemplateAction(label, GetShopCategoryUrl(categoryId));

        /// <summary>
        /// Opens a list of sticker sets from a specified author.
        /// </summary>
        /// <param name="authorId">
        /// Find the "author ID" in the URL of author pages in the "Official stickers" section of the LINE STORE.
        /// </param>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStickerAuthorUrl(string authorId) => string.Format(shopStickerAuthor, authorId);

        /// <summary>
        /// Opens a list of sticker sets from a specified author.
        /// </summary>
        /// <param name="authorId">
        /// Find the "author ID" in the URL of author pages in the "Official stickers" section of the LINE STORE.
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStickerAuthorUriTemplateAction(string label, string authorId)
            => new UriTemplateAction(label, GetShopStickerAuthorUrl(authorId));

        /// <summary>
        /// Opens the               "HOME" tab in the "Sticker Shop" screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetStickerShopUrl() => stickerShop;

        /// <summary>
        /// Opens the               "HOME" tab in the "Sticker Shop" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetStickerShopUriTemplateAction(string label) => new UriTemplateAction(label, GetStickerShopUrl());

        /// <summary>
        /// Opens the "NEW" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStickerNewUrl() => shopStickerNew;

        /// <summary>
        /// Opens the "NEW" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStickerNewUriTemplateAction(string label) => new UriTemplateAction(label, GetShopStickerNewUrl());

        /// <summary>
        /// Opens the "RANK" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStikerHotUrl() => shopStikerHot;

        /// <summary>
        /// Opens the "RANK" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStikerHotUriTemplateAction(string label) => new UriTemplateAction(label, GetShopStikerHotUrl());

        /// <summary>
        /// Opens the "FREE" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStickerEventUrl() => shopStickerEvent;

        /// <summary>
        /// Opens the "FREE" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStickerEventUriTemplateAction(string label) => new UriTemplateAction(label, GetShopStickerEventUrl());

        /// <summary>
        /// Opens the "CATEGORIES" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetShopStickerCategoryUrl() => shopStickerCategory;

        /// <summary>
        /// Opens the "CATEGORIES" tab in the "Sticker Shop" screen.Note: Not supported on Android.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetShopStickerCategoryUriTemplateAction(string label) => new UriTemplateAction(label, GetShopStickerCategoryUrl());

        /// <summary>
        /// Opens the "LINE Out" dial pad screen with a preset phone number. 
        /// </summary>
        /// <para>
        /// For example, https://call/81/1022223333 sets the country calling code to "+81" and the local phone number to "1022223333".
        /// </para>
        /// <param name="countryCallingCode">
        /// Specify the country calling code and the phone number as path parameters. Do not include the "+" symbol in the URL. 
        /// </param>
        /// <param name="phoneNumber">
        /// Local phone number
        /// </param>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallUrl(string countryCallingCode, string phoneNumber) => string.Format(call, countryCallingCode, phoneNumber);

        /// <summary>
        /// Opens the "LINE Out" dial pad screen with a preset phone number. 
        /// </summary>
        /// <para>
        /// For example, https://call/81/1022223333 sets the country calling code to "+81" and the local phone number to "1022223333".
        /// </para>
        /// <param name="countryCallingCode">
        /// Specify the country calling code and the phone number as path parameters. Do not include the "+" symbol in the URL. 
        /// </param>
        /// <param name="phoneNumber">
        /// Local phone number
        /// </param>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallUriTemplateAction(string label, string countryCallingCode, string phoneNumber)
            => new UriTemplateAction(label, GetCallUrl(countryCallingCode, phoneNumber));


        /// <summary>
        /// Opens the "Calls" screen of LINE Out.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallsUrl() => calls;

        /// <summary>
        /// Opens the "Calls" screen of LINE Out.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallsUriTemplateAction(string label) => new UriTemplateAction(label, GetCallsUrl());

        /// <summary>
        /// Opens the "LINE Out" dial pad screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallDialpadUrl() => callDialpad;

        /// <summary>
        /// Opens the "LINE Out" dial pad screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallDialpadUriTemplateAction(string label) => new UriTemplateAction(label, GetCallDialpadUrl());

        /// <summary>
        /// Opens the "LINE Out Settings" screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallSettingsUrl() => callSettings;

        /// <summary>
        /// Opens the "LINE Out Settings" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallSettingsUriTemplateAction(string label) => new UriTemplateAction(label, GetCallSettingsUrl());

        /// <summary>
        /// Opens the "Contacts" screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallContactsUrl() => callContacts;

        /// <summary>
        /// Opens the "Contacts" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallContactsUriTemplateAction(string label) => new UriTemplateAction(label, GetCallContactsUrl());

        /// <summary>
        /// Opens the "Redeem for LINE Out Credit" screen.
        /// </summary>
        /// <returns>String of LINE scheme URL</returns>
        public static string GetCallRedeemUrl() => callRedeem;

        /// <summary>
        /// Opens the "Redeem for LINE Out Credit" screen.
        /// </summary>
        /// <param name = "label" > Template action label text</param>
        /// <returns>URI template action object</returns>
        public static UriTemplateAction GetCallRedeemUriTemplateAction(string label) => new UriTemplateAction(label, GetCallRedeemUrl());

    }
}
