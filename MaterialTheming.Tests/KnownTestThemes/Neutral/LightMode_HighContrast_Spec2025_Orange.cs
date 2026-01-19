namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#2D211B";
    public string OnPrimary => "#EBD6CB";
    public string PrimaryContainer => "#5E4F47";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#29231F";
    public string OnSecondary => "#E4D8D2";
    public string SecondaryContainer => "#58504D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#322104";
    public string OnTertiary => "#F6D5A9";
    public string TertiaryContainer => "#654E2D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#8D3621";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#EBE0DC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#282320";
    public string SurfaceDim => "#E3D8D3";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#2D211B";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#48423F";
    public string OutlineVariant => "#57514E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FDE7DC";
    // Primary Fixed
    public string PrimaryFixed => "#5E4F47";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#52443C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#58504D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D4541";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#654E2D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#584322";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
