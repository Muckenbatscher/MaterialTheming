using M2TWinForms.Themes.ThemeBuilderConversion.SerializationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeBuilderConversion
{
    internal class MaterialThemeDeserializer
    {
        public MaterialTheme Deserialize(string json)
        {
            var theme = JsonSerializer.Deserialize<MaterialTheme>(json);
            if (theme == null)
                throw new Exception("Failed to deserialize theme");

            return theme;
        }
    }
}
