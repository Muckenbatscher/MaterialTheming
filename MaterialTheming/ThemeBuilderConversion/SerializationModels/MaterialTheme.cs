using System.Text.Json.Serialization;

namespace MaterialTheming.ThemeBuilderConversion.SerializationModels
{
    internal class MaterialTheme
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("schemes")]
        public Schemes Schemes { get; set; }

        [JsonPropertyName("palettes")]
        public Palettes Palettes { get; set; }
    }
}
