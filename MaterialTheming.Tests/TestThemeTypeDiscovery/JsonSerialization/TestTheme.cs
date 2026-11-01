using System.Text.Json.Serialization;

namespace MaterialTheming.Tests.TestThemeTypeDiscovery.JsonSerialization;

internal record TestTheme
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("inputs")]
    public required Inputs Inputs { get; set; }

    [JsonPropertyName("outputs")]
    public required Outputs Outputs { get; set; }
}
