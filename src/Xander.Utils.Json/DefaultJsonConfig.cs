using Newtonsoft.Json;

namespace Xander.Utils.Json
{
    public static class DefaultJsonConfig
    {
        static DefaultJsonConfig() 
        {
            JsonFormatting = Formatting.None;
        }
        public static Formatting JsonFormatting { get; set; }
    }
}