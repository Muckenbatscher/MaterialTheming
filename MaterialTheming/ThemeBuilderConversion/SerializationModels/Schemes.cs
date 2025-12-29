using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels
{
    internal class Schemes
    {
        [JsonPropertyName("light")]
        public Scheme? Light { get; set; }

        [JsonPropertyName("light-medium-contrast")]
        public Scheme? LightMediumContrast { get; set; }

        [JsonPropertyName("light-high-contrast")]
        public Scheme? LightHighContrast { get; set; }

        [JsonPropertyName("dark")]
        public Scheme? Dark { get; set; }

        [JsonPropertyName("dark-medium-contrast")]
        public Scheme? DarkMediumContrast { get; set; }

        [JsonPropertyName("dark-high-contrast")]
        public Scheme? DarkHighContrast { get; set; }
    }
}
