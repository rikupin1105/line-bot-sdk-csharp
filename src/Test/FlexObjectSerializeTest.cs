using LineMessagingAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;

namespace Test
{
    [TestClass]
    public class FlexObjectSerializeTest
    {
        private static JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };
        static FlexObjectSerializeTest()
        {
            _jsonSerializerSettings.Converters.Add(new StringEnumConverter { NamingStrategy = new CamelCaseNamingStrategy() });
        }

        [TestMethod]
        public void RestrantTest()
        {
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

            var jsonA = JsonConvert.SerializeObject(flex, _jsonSerializerSettings);
            Console.WriteLine(jsonA);
        }
    }
}