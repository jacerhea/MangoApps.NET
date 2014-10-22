using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MangoApps.Client.Converter
{
    public class SecondEpochConverter : DateTimeConverterBase
    {
        private readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - _epoch).TotalSeconds.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return _epoch.AddSeconds(long.Parse(reader.Value.ToString()));
        }
    }
}
