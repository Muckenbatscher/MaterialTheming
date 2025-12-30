using System.Text.Json.Serialization;

namespace MaterialTheming.MaterialThemeBuilderConversion.SerializationModels
{
    internal class Scheme
    {
        [JsonPropertyName("primary")]
        public string Primary { get; set; } = string.Empty;

        [JsonPropertyName("surfaceTint")]
        public string SurfaceTint { get; set; } = string.Empty;

        [JsonPropertyName("onPrimary")]
        public string OnPrimary { get; set; } = string.Empty;

        [JsonPropertyName("primaryContainer")]
        public string PrimaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onPrimaryContainer")]
        public string OnPrimaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("secondary")]
        public string Secondary { get; set; } = string.Empty;

        [JsonPropertyName("onSecondary")]
        public string OnSecondary { get; set; } = string.Empty;

        [JsonPropertyName("secondaryContainer")]
        public string SecondaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onSecondaryContainer")]
        public string OnSecondaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("tertiary")]
        public string Tertiary { get; set; } = string.Empty;

        [JsonPropertyName("onTertiary")]
        public string OnTertiary { get; set; } = string.Empty;

        [JsonPropertyName("tertiaryContainer")]
        public string TertiaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onTertiaryContainer")]
        public string OnTertiaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;

        [JsonPropertyName("onError")]
        public string OnError { get; set; } = string.Empty;

        [JsonPropertyName("errorContainer")]
        public string ErrorContainer { get; set; } = string.Empty;

        [JsonPropertyName("onErrorContainer")]
        public string OnErrorContainer { get; set; } = string.Empty;

        [JsonPropertyName("surface")]
        public string Surface { get; set; } = string.Empty;

        [JsonPropertyName("onSurface")]
        public string OnSurface { get; set; } = string.Empty;

        [JsonPropertyName("surfaceVariant")]
        public string SurfaceVariant { get; set; } = string.Empty;

        [JsonPropertyName("onSurfaceVariant")]
        public string OnSurfaceVariant { get; set; } = string.Empty;

        [JsonPropertyName("surfaceContainerLowest")]
        public string SurfaceContainerLowest { get; set; } = string.Empty;

        [JsonPropertyName("surfaceContainerLow")]
        public string SurfaceContainerLow { get; set; } = string.Empty;

        [JsonPropertyName("surfaceContainer")]
        public string SurfaceContainer { get; set; } = string.Empty;

        [JsonPropertyName("surfaceContainerHigh")]
        public string SurfaceContainerHigh { get; set; } = string.Empty;

        [JsonPropertyName("surfaceContainerHighest")]
        public string SurfaceContainerHighest { get; set; } = string.Empty;
    }
}
