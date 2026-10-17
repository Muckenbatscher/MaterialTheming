namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFC7B";
    public string OnPrimary => "#4F4E00";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#E8E667";
    // Secondary
    public string Secondary => "#E8E5AA";
    public string OnSecondary => "#424115";
    public string SecondaryContainer => "#49491C";
    public string OnSecondaryContainer => "#E6E3A7";
    // Tertiary
    public string Tertiary => "#FFC566";
    public string OnTertiary => "#462E00";
    public string TertiaryContainer => "#E8A731";
    public string OnTertiaryContainer => "#382400";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#EDEAC3";
    public string OnSurfaceVariant => "#D2D0AA";
    public string SurfaceDim => "#0F0F00";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#FFFC7B";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9A784";
    public string OutlineVariant => "#898766";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFBD3";
    public string InverseOnSurface => "#575639";
    public string InversePrimary => "#595800";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC7B";
    public string OnPrimaryFixed => "#4F4E00";
    public string PrimaryFixedDim => "#F0EE6E";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#424115";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#49491C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC566";
    public string OnTertiaryFixed => "#462E00";
    public string TertiaryFixedDim => "#F7B53E";
    public string OnTertiaryFixedVariant => "#604100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27270D";
    public string SurfaceContainer => "#323217";
    public string SurfaceContainerHigh => "#3D3D21";
    public string SurfaceContainerHighest => "#27270D";
}
