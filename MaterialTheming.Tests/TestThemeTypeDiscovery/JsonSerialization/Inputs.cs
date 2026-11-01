using System.Text.Json.Serialization;

namespace MaterialTheming.Tests.TestThemeTypeDiscovery.JsonSerialization;

internal record Inputs
{
    [JsonPropertyName("color")]
    public required string Color { get; set; }
    [JsonPropertyName("second_color")]
    public string? SecondColor { get; set; }
    [JsonPropertyName("variant")]
    public required string Variant { get; set; }
    [JsonPropertyName("spec_version")]
    public required int SpecVersion { get; set; }
    [JsonPropertyName("platform")]
    public required string Platform { get; set; }
    [JsonPropertyName("is_dark")]
    public required bool IsDark { get; set; }
    [JsonPropertyName("contrast_level")]
    public required double ContrastLevel { get; set; }
}
