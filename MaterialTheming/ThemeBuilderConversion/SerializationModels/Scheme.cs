using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels
{
    internal class Scheme
    {
        [JsonPropertyName("primary")]
        public string Primary { get; set; }

        [JsonPropertyName("surfaceTint")]
        public string SurfaceTint { get; set; }

        [JsonPropertyName("onPrimary")]
        public string OnPrimary { get; set; }

        [JsonPropertyName("primaryContainer")]
        public string PrimaryContainer { get; set; }

        [JsonPropertyName("onPrimaryContainer")]
        public string OnPrimaryContainer { get; set; }

        [JsonPropertyName("secondary")]
        public string Secondary { get; set; }

        [JsonPropertyName("onSecondary")]
        public string OnSecondary { get; set; }

        [JsonPropertyName("secondaryContainer")]
        public string SecondaryContainer { get; set; }

        [JsonPropertyName("onSecondaryContainer")]
        public string OnSecondaryContainer { get; set; }

        [JsonPropertyName("tertiary")]
        public string Tertiary { get; set; }

        [JsonPropertyName("onTertiary")]
        public string OnTertiary { get; set; }

        [JsonPropertyName("tertiaryContainer")]
        public string TertiaryContainer { get; set; }

        [JsonPropertyName("onTertiaryContainer")]
        public string OnTertiaryContainer { get; set; }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("onError")]
        public string OnError { get; set; }

        [JsonPropertyName("errorContainer")]
        public string ErrorContainer { get; set; }

        [JsonPropertyName("onErrorContainer")]
        public string OnErrorContainer { get; set; }

        [JsonPropertyName("surface")]
        public string Surface { get; set; }

        [JsonPropertyName("onSurface")]
        public string OnSurface { get; set; }

        [JsonPropertyName("surfaceVariant")]
        public string SurfaceVariant { get; set; }

        [JsonPropertyName("onSurfaceVariant")]
        public string OnSurfaceVariant { get; set; }

        [JsonPropertyName("surfaceContainerLowest")]
        public string SurfaceContainerLowest { get; set; }

        [JsonPropertyName("surfaceContainerLow")]
        public string SurfaceContainerLow { get; set; }

        [JsonPropertyName("surfaceContainer")]
        public string SurfaceContainer { get; set; }

        [JsonPropertyName("surfaceContainerHigh")]
        public string SurfaceContainerHigh { get; set; }

        [JsonPropertyName("surfaceContainerHighest")]
        public string SurfaceContainerHighest { get; set; }
    }
}
