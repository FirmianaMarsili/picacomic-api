using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic.Http.Response
{
    /// <summary>
    /// 接口返回的数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseBase<T>
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("error")]
        [JsonConverter(typeof(ParseStringConverter))]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }

        public bool Success
        {
            get { return Code == 200 && Message == "success" && Error == 0 && Detail == null; }

        }
        public static ResponseBase<T> FromJson(string json) => JsonConvert.DeserializeObject<ResponseBase<T>>(json, Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            Formatting = Formatting.Indented,
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(int) || t == typeof(int?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            int l;
            if (Int32.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (int)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }        
    }
}
