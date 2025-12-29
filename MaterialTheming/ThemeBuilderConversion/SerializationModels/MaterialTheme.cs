using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels
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
