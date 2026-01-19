namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3C434F";
    public string OnPrimary => "#D3DAE9";
    public string PrimaryContainer => "#6E7582";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#414348";
    public string OnSecondary => "#D8D9E0";
    public string SecondaryContainer => "#73747A";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#40415B";
    public string OnTertiary => "#D8D7F7";
    public string TertiaryContainer => "#72728F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2524";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FCF8F9";
    public string SurfaceVariant => "#E4E2E5";
    public string OnSurface => "#232426";
    public string OnSurfaceVariant => "#424345";
    public string SurfaceDim => "#DBD9DD";
    public string SurfaceBright => "#FCF8F9";
    public string SurfaceTint => "#3C434F";
    // Background
    public string Background => "#FCF8F9";
    public string OnBackground => "#232426";
    // Outline
    public string Outline => "#5F5F61";
    public string OutlineVariant => "#7B7A7D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0F";
    public string InverseOnSurface => "#C7C4C5";
    public string InversePrimary => "#E2E8F8";
    // Primary Fixed
    public string PrimaryFixed => "#6E7582";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#626875";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#73747A";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#66686E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#72728F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#656682";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
