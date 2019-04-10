namespace Default.Loggers
{
    using Newtonsoft.Json;

    internal static class JsonConvertExtensions
    {
        internal static string Serialize<TValue>(this TValue value) =>
            JsonConvert.SerializeObject(value, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto
            });
    }
}
