using Nancy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.Common.Extensions
{
    public class JsonNetSerializer : ISerializer
    {
        private readonly JsonSerializer _serializer;

        public JsonNetSerializer()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                FloatParseHandling = FloatParseHandling.Decimal,
                Culture = new CultureInfo(CultureInfo.CurrentCulture.ToString())
                {
                    NumberFormat = new NumberFormatInfo
                    {
                        NumberDecimalDigits = 2,
                        CurrencyDecimalDigits = 2
                    }
                }
            };

            _serializer = JsonSerializer.Create(settings);
        }

        public IEnumerable<string> Extensions => throw new NotImplementedException();

        public bool CanSerialize(string contentType)
        {
            return contentType == "application/json";
        }

        public void Serialize<TModel>(string contentType, TModel model, Stream outputStream)
        {
            using (var writer = new JsonTextWriter(new StreamWriter(outputStream)))
            {
                _serializer.Serialize(writer, model);
                writer.Flush();
            }
        }
    }
}
