using System.Text.Json.Serialization;

namespace MaterialTheming.Tests.TestThemeDiscovery.Json;

internal record TestThemeSerialization
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("inputs")]
    public required InputsSerialization Inputs { get; set; }

    [JsonPropertyName("outputs")]
    public required OutputsSerialization Outputs { get; set; }
}
