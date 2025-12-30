using System.Text.Json.Serialization;

namespace MaterialTheming.MaterialThemeBuilderConversion.SerializationModels
{
    internal class MaterialTheme
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("schemes")]
        public Schemes Schemes { get; set; } = new Schemes();

        [JsonPropertyName("palettes")]
        public Palettes Palettes { get; set; } = new Palettes();
    }
}
