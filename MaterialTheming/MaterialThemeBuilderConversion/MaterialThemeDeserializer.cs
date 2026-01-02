using MaterialTheming.MaterialThemeBuilderConversion.SerializationModels;
using System.Text.Json;

namespace MaterialTheming.MaterialThemeBuilderConversion
{
    internal class MaterialThemeDeserializer
    {
        public static MaterialTheme Deserialize(string json)
        {
            return JsonSerializer.Deserialize<MaterialTheme>(json)
                ?? throw new Exception("Failed to deserialize theme");
        }
    }
}
