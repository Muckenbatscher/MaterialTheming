using MaterialTheming.ThemeBuilderConversion.SerializationModels;
using System.Text.Json;

namespace MaterialTheming.ThemeBuilderConversion
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
