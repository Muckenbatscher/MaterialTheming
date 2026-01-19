namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E3E089";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#969445";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E1DEB9";
    public string OnSecondary => "#27270E";
    public string SecondaryContainer => "#949271";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#BAE6D1";
    public string OnTertiary => "#002C1F";
    public string TertiaryContainer => "#709A87";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#14140C";
    public string SurfaceVariant => "#48473A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDCB";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#46453B";
    public string SurfaceTint => "#CDCA75";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E2D5";
    // Outline
    public string Outline => "#B5B2A2";
    public string OutlineVariant => "#939181";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2D5";
    public string InverseOnSurface => "#2B2A22";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#121200";
    public string PrimaryFixedDim => "#CDCA75";
    public string OnPrimaryFixedVariant => "#393800";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#121201";
    public string SecondaryFixedDim => "#CBC8A4";
    public string OnSecondaryFixedVariant => "#38371D";
    // Tertiary Fixed
    public string TertiaryFixed => "#C0ECD7";
    public string OnTertiaryFixed => "#00150D";
    public string TertiaryFixedDim => "#A4D0BC";
    public string OnTertiaryFixedVariant => "#133D2F";
    // Surface Container
    public string SurfaceContainerLowest => "#080803";
    public string SurfaceContainerLow => "#1E1E16";
    public string SurfaceContainer => "#292820";
    public string SurfaceContainerHigh => "#34332A";
    public string SurfaceContainerHighest => "#3F3E35";
}
