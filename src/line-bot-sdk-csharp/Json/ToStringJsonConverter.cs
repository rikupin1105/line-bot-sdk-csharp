﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI
{

    public class ToStringJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is not null)
            {
                writer.WriteValue(value.ToString());
            }
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

    }
}
