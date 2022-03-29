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

## Flex Message


画像のようなFlex Messageを作成する場合  
![image](https://user-images.githubusercontent.com/41769991/160522785-4a3593b2-a3b1-4712-86a3-cabb79d109cf.png)
```cs
var flex = new BubbleContainer()
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
```
#### 送信する
```cs
var messages = new ISendMessage[]
{
    new FlexMessage("altText", flex)
};
await LineMessagingClient.ReplyMessageAsync("replyToken", messages);
```
