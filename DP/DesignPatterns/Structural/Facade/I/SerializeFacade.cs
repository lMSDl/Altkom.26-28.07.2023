using Newtonsoft.Json;

namespace DP.DesignPatterns.Structural.Facade.I
{
    internal static class SerializeFacade
    {
        static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            DateFormatString = "yy MMM d"
        };

        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}
