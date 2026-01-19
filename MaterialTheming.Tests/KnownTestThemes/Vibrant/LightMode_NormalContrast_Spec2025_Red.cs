namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#AE2622";
    public string OnPrimary => "#FFEFED";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#4F0003";
    // Secondary
    public string Secondary => "#9F364B";
    public string OnSecondary => "#FFEFEF";
    public string SecondaryContainer => "#FFC2C8";
    public string OnSecondaryContainer => "#852138";
    // Tertiary
    public string Tertiary => "#7841A5";
    public string OnTertiary => "#FCEEFF";
    public string TertiaryContainer => "#D199FF";
    public string OnTertiaryContainer => "#4A0C76";
    // Error
    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";
    // Surface
    public string Surface => "#FFF4F4";
    public string SurfaceVariant => "#FFD2D6";
    public string OnSurface => "#4D2128";
    public string OnSurfaceVariant => "#824C53";
    public string SurfaceDim => "#FFC6CC";
    public string SurfaceBright => "#FFF4F4";
    public string SurfaceTint => "#AE2622";
    // Background
    public string Background => "#FFF4F4";
    public string OnBackground => "#4D2128";
    // Outline
    public string Outline => "#A1676E";
    public string OutlineVariant => "#DE9CA3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#240209";
    public string InverseOnSurface => "#CC8C93";
    public string InversePrimary => "#FC5E52";
    // Primary Fixed
    public string PrimaryFixed => "#FF766A";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FC5E52";
    public string OnPrimaryFixedVariant => "#600004";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC2C8";
    public string OnSecondaryFixed => "#6A0B26";
    public string SecondaryFixedDim => "#FFAEB8";
    public string OnSecondaryFixedVariant => "#912B41";
    // Tertiary Fixed
    public string TertiaryFixed => "#D199FF";
    public string OnTertiaryFixed => "#280046";
    public string TertiaryFixedDim => "#C48BF4";
    public string OnTertiaryFixedVariant => "#531A80";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
