using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#00282E";
    public string OnPrimary => "#A1E5F2";
    public string PrimaryContainer => "#025B66";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#0E272B";
    public string OnSecondary => "#C5DFE4";
    public string SecondaryContainer => "#3E565B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002641";
    public string OnTertiary => "#C0DDFF";
    public string TertiaryContainer => "#355573";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#972B2B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6FAFB";
    public string SurfaceVariant => "#DAE4E7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#1C2627";
    public string SurfaceDim => "#D1DCDE";
    public string SurfaceBright => "#F6FAFB";
    public string SurfaceTint => "#00282E";
    // Background
    public string Background => "#F6FAFB";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#3B4546";
    public string OutlineVariant => "#4A5456";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0A0F10";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A9EEFA";
    // Primary Fixed
    public string PrimaryFixed => "#025B66";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004E58";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3E565B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#324A4F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#355573";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#294967";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
