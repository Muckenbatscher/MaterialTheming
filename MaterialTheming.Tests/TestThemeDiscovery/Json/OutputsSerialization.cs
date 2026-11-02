using System.Text.Json.Serialization;

namespace MaterialTheming.Tests.TestThemeDiscovery.Json;

internal record OutputsSerialization
{
    [JsonPropertyName("primary")]
    public required string Primary { get; set; }
    [JsonPropertyName("on_primary")]
    public required string OnPrimary { get; set; }
    [JsonPropertyName("primary_container")]
    public required string PrimaryContainer { get; set; }
    [JsonPropertyName("on_primary_container")]
    public required string OnPrimaryContainer { get; set; }

    [JsonPropertyName("secondary")]
    public required string Secondary { get; set; }
    [JsonPropertyName("on_secondary")]
    public required string OnSecondary { get; set; }
    [JsonPropertyName("secondary_container")]
    public required string SecondaryContainer { get; set; }
    [JsonPropertyName("on_secondary_container")]
    public required string OnSecondaryContainer { get; set; }

    [JsonPropertyName("tertiary")]
    public required string Tertiary { get; set; }
    [JsonPropertyName("on_tertiary")]
    public required string OnTertiary { get; set; }
    [JsonPropertyName("tertiary_container")]
    public required string TertiaryContainer { get; set; }
    [JsonPropertyName("on_tertiary_container")]
    public required string OnTertiaryContainer { get; set; }

    [JsonPropertyName("error")]
    public required string Error { get; set; }
    [JsonPropertyName("on_error")]
    public required string OnError { get; set; }
    [JsonPropertyName("error_container")]
    public required string ErrorContainer { get; set; }
    [JsonPropertyName("on_error_container")]
    public required string OnErrorContainer { get; set; }

    [JsonPropertyName("surface")]
    public required string Surface { get; set; }
    [JsonPropertyName("surface_variant")]
    public required string SurfaceVariant { get; set; }
    [JsonPropertyName("on_surface")]
    public required string OnSurface { get; set; }
    [JsonPropertyName("on_surface_variant")]
    public required string OnSurfaceVariant { get; set; }
    [JsonPropertyName("surface_dim")]
    public required string SurfaceDim { get; set; }
    [JsonPropertyName("surface_bright")]
    public required string SurfaceBright { get; set; }
    [JsonPropertyName("surface_tint")]
    public required string SurfaceTint { get; set; }

    [JsonPropertyName("surface_container_lowest")]
    public required string SurfaceContainerLowest { get; set; }
    [JsonPropertyName("surface_container_low")]
    public required string SurfaceContainerLow { get; set; }
    [JsonPropertyName("surface_container")]
    public required string SurfaceContainer { get; set; }
    [JsonPropertyName("surface_container_high")]
    public required string SurfaceContainerHigh { get; set; }
    [JsonPropertyName("surface_container_highest")]
    public required string SurfaceContainerHighest { get; set; }

    [JsonPropertyName("background")]
    public required string Background { get; set; }
    [JsonPropertyName("on_background")]
    public required string OnBackground { get; set; }

    [JsonPropertyName("outline")]
    public required string Outline { get; set; }
    [JsonPropertyName("outline_variant")]
    public required string OutlineVariant { get; set; }

    [JsonPropertyName("shadow")]
    public required string Shadow { get; set; }
    [JsonPropertyName("scrim")]
    public required string Scrim { get; set; }

    [JsonPropertyName("inverse_surface")]
    public required string InverseSurface { get; set; }
    [JsonPropertyName("inverse_on_surface")]
    public required string InverseOnSurface { get; set; }
    [JsonPropertyName("inverse_primary")]
    public required string InversePrimary { get; set; }

    [JsonPropertyName("primary_fixed")]
    public required string PrimaryFixed { get; set; }
    [JsonPropertyName("on_primary_fixed")]
    public required string OnPrimaryFixed { get; set; }
    [JsonPropertyName("primary_fixed_dim")]
    public required string PrimaryFixedDim { get; set; }
    [JsonPropertyName("on_primary_fixed_variant")]
    public required string OnPrimaryFixedVariant { get; set; }

    [JsonPropertyName("secondary_fixed")]
    public required string SecondaryFixed { get; set; }
    [JsonPropertyName("on_secondary_fixed")]
    public required string OnSecondaryFixed { get; set; }
    [JsonPropertyName("secondary_fixed_dim")]
    public required string SecondaryFixedDim { get; set; }
    [JsonPropertyName("on_secondary_fixed_variant")]
    public required string OnSecondaryFixedVariant { get; set; }

    [JsonPropertyName("tertiary_fixed")]
    public required string TertiaryFixed { get; set; }
    [JsonPropertyName("on_tertiary_fixed")]
    public required string OnTertiaryFixed { get; set; }
    [JsonPropertyName("tertiary_fixed_dim")]
    public required string TertiaryFixedDim { get; set; }
    [JsonPropertyName("on_tertiary_fixed_variant")]
    public required string OnTertiaryFixedVariant { get; set; }
}
