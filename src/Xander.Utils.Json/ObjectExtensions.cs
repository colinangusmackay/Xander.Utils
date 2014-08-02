using Newtonsoft.Json;

namespace Xander.Utils.Json
{
    public static class ObjectExtensions
    {
        public static string AsJson(this object target)
        {
            return JsonConvert.SerializeObject(target, DefaultJsonConfig.JsonFormatting);
        }

        public static string AsJson(this object target, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(target, DefaultJsonConfig.JsonFormatting, settings);
        }

    }
}