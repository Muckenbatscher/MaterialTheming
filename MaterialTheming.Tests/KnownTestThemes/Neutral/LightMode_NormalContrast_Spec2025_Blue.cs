using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#585F6B";
    public string OnPrimary => "#F6F7FF";
    public string PrimaryContainer => "#DCE2F2";
    public string OnPrimaryContainer => "#4B525E";
    // Secondary
    public string Secondary => "#5D5F65";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#E1E2E9";
    public string OnSecondaryContainer => "#505257";
    // Tertiary
    public string Tertiary => "#5C5D78";
    public string OnTertiary => "#FBF7FF";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#4B4C67";
    // Error
    public string Error => "#9F403D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8983";
    public string OnErrorContainer => "#752121";
    // Surface
    public string Surface => "#FCF8F9";
    public string SurfaceVariant => "#E4E2E5";
    public string OnSurface => "#323235";
    public string OnSurfaceVariant => "#5F5F61";
    public string SurfaceDim => "#DBD9DD";
    public string SurfaceBright => "#FCF8F9";
    public string SurfaceTint => "#585F6B";
    // Background
    public string Background => "#FCF8F9";
    public string OnBackground => "#323235";
    // Outline
    public string Outline => "#7B7A7D";
    public string OutlineVariant => "#B2B1B4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0F";
    public string InverseOnSurface => "#9E9C9D";
    public string InversePrimary => "#E2E8F8";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#39404B";
    public string PrimaryFixedDim => "#CED4E3";
    public string OnPrimaryFixedVariant => "#555C68";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E2E9";
    public string OnSecondaryFixed => "#3D3F45";
    public string SecondaryFixedDim => "#D3D4DA";
    public string OnSecondaryFixedVariant => "#595B61";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBDAFB";
    public string OnTertiaryFixed => "#393A53";
    public string TertiaryFixedDim => "#CDCCEC";
    public string OnTertiaryFixedVariant => "#555671";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
