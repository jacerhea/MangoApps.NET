using System;
using Newtonsoft.Json;

namespace MangoApps.Client
{
    public class YNConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((bool)value ? "Y" : "N");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ((string)reader.Value) == "Y" || ((string)reader.Value) == "true" || ((string)reader.Value) == "YES";
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
