namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#003F79";
    public string OnPrimary => "#BDD5FF";
    public string PrimaryContainer => "#0075D7";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#003A90";
    public string OnSecondary => "#C5D3FF";
    public string SecondaryContainer => "#4570D2";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#631E7C";
    public string OnTertiary => "#F4C4FF";
    public string TertiaryContainer => "#9E58B6";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#850012";
    public string OnError => "#FFC7C2";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6F6FF";
    public string SurfaceVariant => "#D2DCFF";
    public string OnSurface => "#0E1E41";
    public string OnSurfaceVariant => "#303E63";
    public string SurfaceDim => "#C6D3FF";
    public string SurfaceBright => "#F6F6FF";
    public string SurfaceTint => "#003F79";
    // Background
    public string Background => "#F6F6FF";
    public string OnBackground => "#0E1E41";
    // Outline
    public string Outline => "#4C5B81";
    public string OutlineVariant => "#68769E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#000C2B";
    public string InverseOnSurface => "#B5C4F0";
    public string InversePrimary => "#529EFF";
    // Primary Fixed
    public string PrimaryFixed => "#0075D7";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#0068C1";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4570D2";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3664C4";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9E58B6";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#904BA9";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
