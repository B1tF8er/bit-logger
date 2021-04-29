namespace Default.Loggers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;
    using System.Collections.Generic;

    internal static class JsonConvertExtensions
    {
        internal static string Serialize<TValue>(this TValue value) =>
            JsonConvert.SerializeObject(value, new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    new StringEnumConverter
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                },
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto
            });
    }
}
