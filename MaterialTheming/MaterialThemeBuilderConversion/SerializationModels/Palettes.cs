using System.Text.Json.Serialization;

namespace MaterialTheming.MaterialThemeBuilderConversion.SerializationModels
{
    internal class Palettes
    {
        [JsonPropertyName("primary")]
        public Dictionary<string, string> Primary { get; set; } = [];

        [JsonPropertyName("secondary")]
        public Dictionary<string, string> Secondary { get; set; } = [];

        [JsonPropertyName("tertiary")]
        public Dictionary<string, string> Tertiary { get; set; } = [];

        [JsonPropertyName("neutral")]
        public Dictionary<string, string> Neutral { get; set; } = [];

        [JsonPropertyName("neutral-variant")]
        public Dictionary<string, string> NeutralVariant { get; set; } = [];
    }
}
