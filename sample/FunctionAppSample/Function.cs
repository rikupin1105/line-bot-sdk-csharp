using LineMessagingAPI;
using LineMessagingAPI.Webhooks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunctionAppSample
{
    public static class Function
    {
        [FunctionName("Function")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequestMessage req, ILogger log)
        {
            {
                try
                {
                    log.LogInformation(req.Content.ReadAsStringAsync().Result);
                    var channelSecret = Environment.GetEnvironmentVariable("CHANNEL_SEACRET");
                    var events = await req.GetWebhookEventsAsync(channelSecret);

                    var app = new LineBotApp();

                    await app.RunAsync(events);

                }
                catch (InvalidSignatureException e)
                {
                    return req.CreateResponse(HttpStatusCode.Forbidden, new { e.Message });
                }

                return req.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}
