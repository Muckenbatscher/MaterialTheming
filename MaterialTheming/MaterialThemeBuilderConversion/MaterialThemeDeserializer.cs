using MaterialTheming.MaterialThemeBuilderConversion.SerializationModels;
using System.Text.Json;

namespace MaterialTheming.MaterialThemeBuilderConversion
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
