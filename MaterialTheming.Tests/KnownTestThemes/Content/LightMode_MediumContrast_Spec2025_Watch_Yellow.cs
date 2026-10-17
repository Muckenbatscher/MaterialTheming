namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#302F00";
    public string PrimaryContainer => "#8B8A0C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#212100";
    public string SecondaryContainer => "#8A8854";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#0F0700";
    public string TertiaryContainer => "#E8A731";
    public string OnTertiaryContainer => "#382400";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CF674E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D2D0AA";
    public string SurfaceDim => "#0F0F00";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#3A391E";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC7B";
    public string OnPrimaryFixed => "#302F00";
    public string PrimaryFixedDim => "#F0EE6E";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#212100";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#424115";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC566";
    public string OnTertiaryFixed => "#0F0700";
    public string TertiaryFixedDim => "#F7B53E";
    public string OnTertiaryFixedVariant => "#462E00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27270D";
    public string SurfaceContainer => "#323217";
    public string SurfaceContainerHigh => "#3D3D21";
    public string SurfaceContainerHighest => "#27270D";
}
