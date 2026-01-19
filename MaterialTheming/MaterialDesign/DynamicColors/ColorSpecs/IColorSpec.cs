using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;

internal interface IColorSpec
{
    // Surfaces
    DynamicColor Background { get; }
    DynamicColor OnBackground { get; }
    DynamicColor Surface { get; }
    DynamicColor SurfaceDim { get; }
    DynamicColor SurfaceBright { get; }
    DynamicColor SurfaceContainerLowest { get; }
    DynamicColor SurfaceContainerLow { get; }
    DynamicColor SurfaceContainer { get; }
    DynamicColor SurfaceContainerHigh { get; }
    DynamicColor SurfaceContainerHighest { get; }
    DynamicColor OnSurface { get; }
    DynamicColor SurfaceVariant { get; }
    DynamicColor OnSurfaceVariant { get; }
    DynamicColor InverseSurface { get; }
    DynamicColor InverseOnSurface { get; }
    DynamicColor Outline { get; }
    DynamicColor OutlineVariant { get; }
    DynamicColor Shadow { get; }
    DynamicColor Scrim { get; }
    DynamicColor SurfaceTint { get; }

    // Primaries
    DynamicColor Primary { get; }
    DynamicColor? PrimaryDim { get; }
    DynamicColor OnPrimary { get; }
    DynamicColor PrimaryContainer { get; }
    DynamicColor OnPrimaryContainer { get; }
    DynamicColor InversePrimary { get; }

    // Secondaries
    DynamicColor Secondary { get; }
    DynamicColor? SecondaryDim { get; }
    DynamicColor OnSecondary { get; }
    DynamicColor SecondaryContainer { get; }
    DynamicColor OnSecondaryContainer { get; }

    // Tertiaries
    DynamicColor Tertiary { get; }
    DynamicColor? TertiaryDim { get; }
    DynamicColor OnTertiary { get; }
    DynamicColor TertiaryContainer { get; }
    DynamicColor OnTertiaryContainer { get; }

    // Errors
    DynamicColor Error { get; }
    DynamicColor? ErrorDim { get; }
    DynamicColor OnError { get; }
    DynamicColor ErrorContainer { get; }
    DynamicColor OnErrorContainer { get; }

    // Primary Fixed
    DynamicColor PrimaryFixed { get; }
    DynamicColor PrimaryFixedDim { get; }
    DynamicColor OnPrimaryFixed { get; }
    DynamicColor OnPrimaryFixedVariant { get; }

    // Secondary Fixed
    DynamicColor SecondaryFixed { get; }
    DynamicColor SecondaryFixedDim { get; }
    DynamicColor OnSecondaryFixed { get; }
    DynamicColor OnSecondaryFixedVariant { get; }

    // Tertiary Fixed
    DynamicColor TertiaryFixed { get; }
    DynamicColor TertiaryFixedDim { get; }
    DynamicColor OnTertiaryFixed { get; }
    DynamicColor OnTertiaryFixedVariant { get; }

    // Other
    DynamicColor HighestSurface(DynamicScheme s);

    // Calculations
    HctColor GetHct(DynamicScheme scheme, DynamicColor color);
    double GetTone(DynamicScheme scheme, DynamicColor color);

    // Scheme Palettes
    TonalPalette GetPrimaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
    TonalPalette GetSecondaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
    TonalPalette GetTertiaryPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
    TonalPalette GetNeutralPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
    TonalPalette GetNeutralVariantPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
    TonalPalette? GetErrorPalette(Variant variant, HctColor sourceColorHct, bool isDark, Platform platform, double contrastLevel);
}