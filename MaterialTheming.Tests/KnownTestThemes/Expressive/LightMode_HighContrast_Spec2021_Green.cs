namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#53180D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#793426";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#063325";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#285141";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003231";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005251";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F3FCF3";
    public string SurfaceVariant => "#D6E7DB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B2BBB4";
    public string SurfaceBright => "#F3FCF3";
    public string SurfaceTint => "#944839";
    // Background
    public string Background => "#F3FCF3";
    public string OnBackground => "#151D19";
    // Outline
    public string Outline => "#212F27";
    public string OutlineVariant => "#3E4D44";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A322D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB4A5";
    // Primary Fixed
    public string PrimaryFixed => "#793426";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#5C1E12";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#285141";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#0F3A2B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005251";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003938";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EAF3EB";
    public string SurfaceContainer => "#DCE5DD";
    public string SurfaceContainerHigh => "#CDD7CF";
    public string SurfaceContainerHighest => "#C0C9C1";
}
