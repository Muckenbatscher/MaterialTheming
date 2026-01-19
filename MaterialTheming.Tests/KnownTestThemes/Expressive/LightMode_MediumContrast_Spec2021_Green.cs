namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#612115";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A65646";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#133D2F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4C7564";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003D3C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#2E7876";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F3FCF3";
    public string SurfaceVariant => "#D6E7DB";
    public string OnSurface => "#0B130E";
    public string OnSurfaceVariant => "#2B3931";
    public string SurfaceDim => "#C0C9C1";
    public string SurfaceBright => "#F3FCF3";
    public string SurfaceTint => "#944839";
    // Background
    public string Background => "#F3FCF3";
    public string OnBackground => "#151D19";
    // Outline
    public string Outline => "#47564D";
    public string OutlineVariant => "#617167";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A322D";
    public string InverseOnSurface => "#EAF3EB";
    public string InversePrimary => "#FFB4A5";
    // Primary Fixed
    public string PrimaryFixed => "#A65646";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#883F31";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4C7564";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#345D4C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#2E7876";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#065F5E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF6EE";
    public string SurfaceContainer => "#E1EBE2";
    public string SurfaceContainerHigh => "#D6DFD7";
    public string SurfaceContainerHighest => "#CBD4CC";
}
