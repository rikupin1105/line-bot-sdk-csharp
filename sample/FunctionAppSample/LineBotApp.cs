using LineMessagingAPI;
using LineMessagingAPI.Webhooks;
using System;
using System.Threading.Tasks;

namespace FunctionAppSample
{
    class LineBotApp : WebhookApplication
    {
        private LineMessagingClient LineMessagingClient { get; set; }
        public LineBotApp()
        {
            LineMessagingClient = new LineMessagingClient(Environment.GetEnvironmentVariable("CHANNEL_ACCESS_TOKEN")); ;
        }
        protected override async Task OnMessageAsync(MessageEvent ev)
        {
            switch (ev.Message.Type)
            {
                case EventMessageType.Text:
                    await Messaging(ev);
                    break;

                case EventMessageType.Image:
                case EventMessageType.Audio:
                case EventMessageType.Video:
                case EventMessageType.File:
                case EventMessageType.Location:
                case EventMessageType.Sticker:
                    break;
            }
        }

        private async Task Messaging(MessageEvent ev)
        {
            //メッセージイベント
            //Message event
            //https://developers.line.biz/ja/reference/messaging-api/#message-event
            //https://developers.line.biz/en/reference/messaging-api/#message-event

            if (!(ev.Message is TextEventMessage msg)) { return; }
            await LineMessagingClient.ReplyTextAsync(ev.ReplyToken, msg.Text);
        }
        protected override async Task OnUnsendAsync(UnsendEvent ev)
        {
            //送信取り消しイベント
            //Unsend event
            //https://developers.line.biz/ja/reference/messaging-api/#unsend-event
            //https://developers.line.biz/en/reference/messaging-api/#unsend-event
        }
        protected override async Task OnJoinAsync(JoinEvent ev)
        {
            //参加イベント
            //Join event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#join-event
            //https://developers.line.biz/en/reference/messaging-api/#join-event
        }

        protected override async Task OnLeaveAsync(LeaveEvent ev)
        {
            //メンバー退出イベント
            //Member left event
            //https://developers.line.biz/ja/reference/messaging-api/#member-left-event
            //https://developers.line.biz/en/reference/messaging-api/#member-left-event
        }

        protected override async Task OnFollowAsync(FollowEvent ev)
        {
            //フォローイベント
            //リプライ可能 Replyable
            //Follow event
            //https://developers.line.biz/ja/reference/messaging-api/#follow-event
            //https://developers.line.biz/en/reference/messaging-api/#follow-event
        }

        protected override async Task OnUnfollowAsync(UnfollowEvent ev)
        {
            //フォロー解除イベント
            //Unfollow event
            //https://developers.line.biz/ja/reference/messaging-api/#unfollow-event
            //https://developers.line.biz/en/reference/messaging-api/#unfollow-event
        }
        protected override async Task OnPostbackAsync(PostbackEvent ev)
        {
            //ポストバックイベント
            //Postback event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#postback-event
            //https://developers.line.biz/en/reference/messaging-api/#postback-event
        }

        protected override async Task OnVideoPlayCompleteAsync(VideoPlayCompleteEvent ev)
        {
            //動画視聴完了イベント
            //Video viewing complete event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#video-viewing-complete
            //https://developers.line.biz/en/reference/messaging-api/#video-viewing-complete
        }

        protected override async Task OnBeaconAsync(BeaconEvent ev)
        {
            //ビーコンイベント
            //Beacon event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#beacon-event
            //https://developers.line.biz/en/reference/messaging-api/#beacon-event
        }


        protected override async Task OnAccountLinkAsync(AccountLinkEvent ev)
        {
            //アカウント連携イベント
            //Account link event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#account-link-event
            //https://developers.line.biz/en/reference/messaging-api/#account-link-event
        }

        protected override async Task OnMemberJoinAsync(MemberJoinEvent ev)
        {
            //メンバー参加イベント
            //member joined event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#member-joined-event
            //https://developers.line.biz/en/reference/messaging-api/#member-joined-event
        }

        protected override async Task OnMemberLeaveAsync(MemberLeaveEvent ev)
        {
            //メンバー退出イベント
            //menber left event
            //https://developers.line.biz/ja/reference/messaging-api/#member-left-event
            //https://developers.line.biz/en/reference/messaging-api/#member-left-event
        }

        protected override async Task OnDeviceLinkAsync(DeviceLinkEvent ev)
        {
            //デバイス連携イベント
            //Device link event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#device-link-event
            //https://developers.line.biz/en/reference/messaging-api/#device-link-event
        }

        protected override async Task OnDeviceUnlinkAsync(DeviceUnlinkEvent ev)
        {
            //デバイス連携解除イベント
            //Device unlink event
            //リプライ可能 Replyable
            //https://developers.line.biz/ja/reference/messaging-api/#device-unlink-event
            //https://developers.line.biz/en/reference/messaging-api/#device-unlink-event
        }
    }
}