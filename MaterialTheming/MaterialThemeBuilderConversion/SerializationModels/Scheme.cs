using System.Text.Json.Serialization;

namespace MaterialTheming.MaterialThemeBuilderConversion.SerializationModels
{
    internal class Scheme
    {
        //Primary
        [JsonPropertyName("primary")]
        public string Primary { get; set; } = string.Empty;

        [JsonPropertyName("onPrimary")]
        public string OnPrimary { get; set; } = string.Empty;

        [JsonPropertyName("primaryContainer")]
        public string PrimaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onPrimaryContainer")]
        public string OnPrimaryContainer { get; set; } = string.Empty;

        //Secondary
        [JsonPropertyName("secondary")]
        public string Secondary { get; set; } = string.Empty;

        [JsonPropertyName("onSecondary")]
        public string OnSecondary { get; set; } = string.Empty;

        [JsonPropertyName("secondaryContainer")]
        public string SecondaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onSecondaryContainer")]
        public string OnSecondaryContainer { get; set; } = string.Empty;

        //Tertiary
        [JsonPropertyName("tertiary")]
        public string Tertiary { get; set; } = string.Empty;

        [JsonPropertyName("onTertiary")]
        public string OnTertiary { get; set; } = string.Empty;

        [JsonPropertyName("tertiaryContainer")]
        public string TertiaryContainer { get; set; } = string.Empty;

        [JsonPropertyName("onTertiaryContainer")]
        public string OnTertiaryContainer { get; set; } = string.Empty;

        //Error
        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;

        [JsonPropertyName("onError")]
        public string OnError { get; set; } = string.Empty;

        [JsonPropertyName("errorContainer")]
        public string ErrorContainer { get; set; } = string.Empty;

        [JsonPropertyName("onErrorContainer")]
        public string OnErrorContainer { get; set; } = string.Empty;

        //Surface
        [JsonPropertyName("surface")]
        public string Surface { get; set; } = string.Empty;

        [JsonPropertyName("surfaceVariant")]
        public string SurfaceVariant { get; set; } = string.Empty;

        [JsonPropertyName("onSurface")]
        public string OnSurface { get; set; } = string.Empty;

        [JsonPropertyName("onSurfaceVariant")]
        public string OnSurfaceVariant { get; set; } = string.Empty;

        [JsonPropertyName("surfaceDim")]
        public string SurfaceDim { get; set; } = string.Empty;

        [JsonPropertyName("surfaceBright")]
        public string SurfaceBright { get; set; } = string.Empty;

        [JsonPropertyName("surfaceTint")]
        public string SurfaceTint { get; set; } = string.Empty;

        //Background
        [JsonPropertyName("background")]
        public string Background { get; set; } = string.Empty;

        [JsonPropertyName("onBackground")]
        public string OnBackground { get; set; } = string.Empty;

        //Background
        [JsonPropertyName("outline")]
        public string Outline { get; set; } = string.Empty;

        [JsonPropertyName("outlineVariant")]
        public string OutlineVariant { get; set; } = string.Empty;

        //Shadow
        [JsonPropertyName("shadow")]
        public string Shadow { get; set; } = string.Empty;

        [JsonPropertyName("scrim")]
        public string Scrim { get; set; } = string.Empty;

        //Inverse
        [JsonPropertyName("inverseSurface")]
        public string InverseSurface { get; set; } = string.Empty;

        [JsonPropertyName("inverseOnSurface")]
        public string InverseOnSurface { get; set; } = string.Empty;

        [JsonPropertyName("inversePrimary")]
        public string InversePrimary { get; set; } = string.Empty;

        //Primary Fixed
        [JsonPropertyName("primaryFixed")]
        public string PrimaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("onPrimaryFixed")]
        public string OnPrimaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("primaryFixedDim")]
        public string PrimaryFixedDim { get; set; } = string.Empty;

        [JsonPropertyName("onPrimaryFixedVariant")]
        public string OnPrimaryFixedVariant { get; set; } = string.Empty;

        //Secondary Fixed
        [JsonPropertyName("secondaryFixed")]
        public string SecondaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("onSecondaryFixed")]
        public string OnSecondaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("secondaryFixedDim")]
        public string SecondaryFixedDim { get; set; } = string.Empty;

        [JsonPropertyName("onSecondaryFixedVariant")]
        public string OnSecondaryFixedVariant { get; set; } = string.Empty;

        //Tertiary Fixed
        [JsonPropertyName("tertiaryFixed")]
        public string TertiaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("onTertiaryFixed")]
        public string OnTertiaryFixed { get; set; } = string.Empty;

        [JsonPropertyName("tertiaryFixedDim")]
        public string TertiaryFixedDim { get; set; } = string.Empty;

        [JsonPropertyName("onTertiaryFixedVariant")]
        public string OnTertiaryFixedVariant { get; set; } = string.Empty;

        //Surface Container
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
