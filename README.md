# LINE Messaging API SDK for C#
LINE Messaging API SDK for C#

[![NuGet](https://img.shields.io/nuget/v/line-bot-sdk-csharp.svg)](https://www.nuget.org/packages/line-bot-sdk-csharp/)
[![NuGet](https://img.shields.io/nuget/dt/line-bot-sdk-csharp.svg)](https://www.nuget.org/packages/line-bot-sdk-csharp/)  

## Installation
Using [nuget](https://www.nuget.org/packages/line-bot-sdk-csharp/)
```
PM> Install-Package line-bot-sdk-csharp
> dotnet add package line-bot-sdk-csharp
```
## Documentation
See the official API documentation for more information
- English: https://developers.line.biz/en/docs/messaging-api/overview/
- Japanese: https://developers.line.biz/ja/docs/messaging-api/overview/

## How to use

### Client
使用するにはまずクライアントを作成します。
```cs
var LineMessagingClient = new LineMessagingClient("channelAccessToken");
```

## メッセージ送信

複数のメッセージを送信する必要がある場合は後述の 複数メッセージを送信する場合 を参照してください。

### テキストメッセージ
ReplyTextAsync もしくは PushTextAsync を使用します。
```cs
await LineMessagingClient.ReplyTextAsync("replyToken", "HelloWorld");
await LineMessagingClient.PushTextAsync("to", "HelloWorld");
```

### スタンプメッセージ
ReplyStickerAsync もしくは PushStickerAsync を使用します。  
packageId と stickerId は [送信可能なスタンプリスト](https://developers.line.biz/ja/docs/messaging-api/sticker-list/) を参照してください.
```cs
await LineMessagingClient.ReplyStickerAsync("replyToken", "packageId", "stickerId");
await LineMessagingClient.PushStickerAsync("to", "packageId", "stickerId");
```

### 画像メッセージ
ReplyImageAsync もしくは PushImageAsync を使用します。  
使用可能な画像URLは [こちら](https://developers.line.biz/ja/reference/messaging-api/#image-message) を参照してください。
```cs
await LineMessagingClient.ReplyImageAsync("replyToken", "originalContentUrl", "previewImageUrl");
await LineMessagingClient.PushImageAsync("to", "originalContentUrl", "previewImageUrl");
```

### 動画メッセージ
ReplyVideoAsync もしくは PushVideoAsync を使用します。  
使用可能な動画URLは [こちら](https://developers.line.biz/ja/reference/messaging-api/#video-message) を参照してください。
```cs
await LineMessagingClient.ReplyVideoAsync("replyToken", "originalContentUrl", "PreviewImageUrl");
await LineMessagingClient.PushVideoAsync("to", "originalContentUrl", "PreviewImageUrl");
```

### 音声メッセージ
ReplyAudioAsync もしくは PushAudioAsync を使用します。  
MessagingAPI では M4A のみサポートしています。MP3ファイル等をお使いの場合は FFmpeg などのサービスをご利用ください。
```cs
await LineMessagingClient.ReplyAudioAsync("replyToken", "originalContentUrl", 2000);
await LineMessagingClient.PushAudioAsync("to", "originalContentUrl", 2000);
```

### 位置情報メッセージ
ReplyLocationAsync もしくは PushLocationAsync を使用します。
```cs
await LineMessagingClient.ReplyLocationAsync("replyToken", "title", "address", (decimal)35.687574, (decimal)139.72922);
await LineMessagingClient.PushLocationAsync("to", "title", "address", (decimal)35.687574, (decimal)139.72922);
```

### イメージマップメッセージ
実装済みです。  
執筆中

### テンプレートメッセージ
実装済みです。  
執筆中

### Flexメッセージ
ReplyFlexMessageAsync もしくは PushLocationAsync を使用します。
```cs
await LineMessagingClient.ReplyFlexMessageAsync("replyToken", "altText", content);
await LineMessagingClient.PushFlexMessageAsync("to", "altText", content);
```

### 複数メッセージを送信する場合
ReplyMessageAsync もしくは PushMessageAsync を使用します。  
同時に配信できるメッセージは 5件 です。
```cs
var messages = new ISendMessage[]
{
    new TextMessage("HelloWorld"),
    new StickerMessage("446","1988")
};
await LineMessagingClient.ReplyMessageAsync("replyToken", messages);
await LineMessagingClient.PushMessageAsync("to", messages);
```

画像のようなFlex Messageを作成する場合  
![image](https://user-images.githubusercontent.com/41769991/160522785-4a3593b2-a3b1-4712-86a3-cabb79d109cf.png)
```cs
var content = new BubbleContainer()
{
    Hero = new ImageComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/01_1_cafe.png")
    {
        Size = "full",
        AspectRatio = "20:13",
        AspectMode = AspectMode.Cover,
        Action = new UriTemplateAction("http://linecorp.com/")
    },
    Body = new BoxComponent(BoxLayout.Vertical)
    {
        Contents = new IFlexComponent[]
        {
            new TextComponent("Brown Cafe")
            {
                Weight = Weight.Bold,
                Size = "xl"
            },
            new BoxComponent(BoxLayout.Baseline)
            {
                Margin = "md",
                Contents = new IFlexComponent[]
                {
                    new IconComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/review_gold_star_28.png")
                    {
                        Size = "sm"
                    },
                    new IconComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/review_gold_star_28.png")
                    {
                        Size = "sm"
                    },
                    new IconComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/review_gold_star_28.png")
                    {
                        Size = "sm"
                    },
                    new IconComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/review_gold_star_28.png")
                    {
                        Size = "sm"
                    },
                    new IconComponent("https://scdn.line-apps.com/n/channel_devcenter/img/fx/review_gray_star_28.png")
                    {
                        Size = "sm"
                    },
                    new TextComponent("4.0")
                    {
                        Size = "sm",
                        Color = "#999999",
                        Margin = "md",
                        Flex = 0
                    }
                }
            },
            new BoxComponent(BoxLayout.Vertical)
            {
                Margin = "lg",
                Spacing = "sm",
                Contents= new IFlexComponent[]
                {
                    new BoxComponent(BoxLayout.Baseline)
                    {
                        Contents= new IFlexComponent[]
                        {
                            new TextComponent("Place")
                            {
                                Color = "#aaaaaa",
                                Size = "sm",
                                Flex = 1
                            },
                            new TextComponent("Miraina Tower, 4-1-6 Shinjuku, Tokyo")
                            {
                                Wrap = true,
                                Color = "#666666",
                                Size = "sm",
                                Flex = 5
                            }
                        }
                    },
                    new BoxComponent(BoxLayout.Baseline)
                    {
                        Spacing = "sm",
                        Contents = new IFlexComponent[]
                        {
                            new TextComponent("Time")
                            {
                                Color = "#aaaaaa",
                                Size = "sm",
                                Flex = 1
                            },
                            new TextComponent("10:00 - 23:00")
                            {
                                Wrap = true,
                                Color = "#666666",
                                Size = "sm",
                                Flex = 5
                            }
                        }
                    }
                }
            }

        }
    },
    Footer = new BoxComponent(BoxLayout.Vertical)
    {
        Spacing = "sm",
        Contents = new IFlexComponent[]
        {
            new ButtonComponent()
            {
                Style = ButtonStyle.Link,
                Height = "sm",
                Action = new UriTemplateAction("https://linecorp.com")
                {
                    Label = "CALL"
                }
            },
            new ButtonComponent()
            {
                Style = ButtonStyle.Link,
                Height = "sm",
                Action = new UriTemplateAction("https://linecorp.com")
                {
                    Label = "WEBSITE"
                }
            },
            new BoxComponent(BoxLayout.Vertical)
            {
                Margin = "sm"
            }
        }
    }
};
