using Newtonsoft.Json;
using System;
using System.Globalization;

namespace ACMERecognition.ManagementService.DTO.Convert
{
    public class DecimalFormatJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal);
        }
        public override bool CanRead
        {
            get { return false; }
        }
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            decimal rounded = Math.Round(System.Convert.ToDecimal(value, CultureInfo.InvariantCulture), 2);
            writer.WriteValue(rounded);
        }
    }
}
