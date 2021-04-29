using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace LineMessagingAPI
{
    internal class CamelCaseJsonSerializerSettings : JsonSerializerSettings
    {
        public CamelCaseJsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver();
            Converters.Add(new StringEnumConverter(true));
            NullValueHandling = NullValueHandling.Ignore;
        }
    }
}
