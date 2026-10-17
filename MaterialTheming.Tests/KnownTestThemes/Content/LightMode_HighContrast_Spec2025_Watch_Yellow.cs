namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#ACAA32";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#AAA872";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E8A731";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F7866B";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#0F0F00";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D2D0AA";
    public string OutlineVariant => "#A9A784";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFBD3";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC7B";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F0EE6E";
    public string OnPrimaryFixedVariant => "#302F00";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#212100";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC566";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F7B53E";
    public string OnTertiaryFixedVariant => "#0F0700";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27270D";
    public string SurfaceContainer => "#323217";
    public string SurfaceContainerHigh => "#3D3D21";
    public string SurfaceContainerHighest => "#27270D";
}
