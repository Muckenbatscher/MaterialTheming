using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#96490B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#743400";
    // Secondary
    public string Secondary => "#765847";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#5C4131";
    // Tertiary
    public string Tertiary => "#626033";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E8E5AC";
    public string OnTertiaryContainer => "#49491E";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#96490B";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C6C6C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#321300";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#743400";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#2B1609";
    public string SecondaryFixedDim => "#E5BFA9";
    public string OnSecondaryFixedVariant => "#5C4131";
    // Tertiary Fixed
    public string TertiaryFixed => "#E8E5AC";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CBC992";
    public string OnTertiaryFixedVariant => "#49491E";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
