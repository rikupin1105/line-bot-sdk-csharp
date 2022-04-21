using Newtonsoft.Json;
using System.Collections.Generic;

namespace LineMessagingAPI.Webhooks
{
    public static class WebhookEventParser
    {
        public static IEnumerable<WebhookEvent> Parse(string webhookContent)
        {
            dynamic dynamicObject = JsonConvert.DeserializeObject(webhookContent);
            if (dynamicObject is null) { yield break; }

            foreach (var ev in dynamicObject.events)
            {
                var webhookEvent = WebhookEvent.CreateFrom(ev);
                if (webhookEvent is null) { continue; }
                yield return webhookEvent;
            }
        }

        public static IEnumerable<WebhookEvent> ParseEvents(dynamic events)
        {
            foreach (var ev in events)
            {
                var webhookEvent = WebhookEvent.CreateFrom(ev);
                if (webhookEvent is null) { continue; }
                yield return webhookEvent;
            }
        }
    }
}
