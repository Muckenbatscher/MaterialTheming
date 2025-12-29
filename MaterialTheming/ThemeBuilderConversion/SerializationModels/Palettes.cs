using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels
{
    internal class Palettes
    {
        [JsonPropertyName("primary")]
        public Dictionary<string, string> Primary { get; set; }

        [JsonPropertyName("secondary")]
        public Dictionary<string, string> Secondary { get; set; }

        [JsonPropertyName("tertiary")]
        public Dictionary<string, string> Tertiary { get; set; }

        [JsonPropertyName("neutral")]
        public Dictionary<string, string> Neutral { get; set; }

        [JsonPropertyName("neutral-variant")]
        public Dictionary<string, string> NeutralVariant { get; set; }
    }
}
