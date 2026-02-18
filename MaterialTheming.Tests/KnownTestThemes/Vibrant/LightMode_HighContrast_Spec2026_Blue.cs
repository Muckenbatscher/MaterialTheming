namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002041";
    public string OnPrimary => "#BED6FF";
    public string PrimaryContainer => "#004F94";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#001C4F";
    public string OnSecondary => "#C6D4FF";
    public string SecondaryContainer => "#1049A9";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#39004D";
    public string OnTertiary => "#F4C4FF";
    public string TertiaryContainer => "#74308D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#480005";
    public string OnError => "#FFC7C3";
    public string ErrorContainer => "#A0071A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6F6FF";
    public string SurfaceVariant => "#D2DCFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#0E1E41";
    public string SurfaceDim => "#C6D3FF";
    public string SurfaceBright => "#F6F6FF";
    public string SurfaceTint => "#002041";
    // Background
    public string Background => "#F6F6FF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#303E63";
    public string OutlineVariant => "#3F4E73";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#000C2B";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A3C6FF";
    // Primary Fixed
    public string PrimaryFixed => "#004F94";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004380";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#1049A9";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#003D98";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#74308D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#672380";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
