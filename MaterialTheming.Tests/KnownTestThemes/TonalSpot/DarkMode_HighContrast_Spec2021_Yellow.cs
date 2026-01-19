namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F7F49A";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C9C772";
    public string OnPrimaryContainer => "#0C0C00";
    // Secondary
    public string Secondary => "#F5F2CC";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C7C4A1";
    public string OnSecondaryContainer => "#0C0C00";
    // Tertiary
    public string Tertiary => "#CDFAE5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A1CCB8";
    public string OnTertiaryContainer => "#000E08";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#14140C";
    public string SurfaceVariant => "#48473A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#525046";
    public string SurfaceTint => "#CDCA75";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E2D5";
    // Outline
    public string Outline => "#F4F0DE";
    public string OutlineVariant => "#C6C3B2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2D5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CDCA75";
    public string OnPrimaryFixedVariant => "#121200";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CBC8A4";
    public string OnSecondaryFixedVariant => "#121201";
    // Tertiary Fixed
    public string TertiaryFixed => "#C0ECD7";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A4D0BC";
    public string OnTertiaryFixedVariant => "#00150D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#202018";
    public string SurfaceContainer => "#313128";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#48473D";
}
