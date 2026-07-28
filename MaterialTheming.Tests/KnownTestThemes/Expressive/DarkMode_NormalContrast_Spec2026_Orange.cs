namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFAF7E";
    public string OnPrimary => "#622E07";
    public string PrimaryContainer => "#6F3811";
    public string OnPrimaryContainer => "#FFC4A1";
    // Secondary
    public string Secondary => "#B9C8DA";
    public string OnSecondary => "#344150";
    public string SecondaryContainer => "#192735";
    public string OnSecondaryContainer => "#97A5B7";
    // Tertiary
    public string Tertiary => "#91CDFF";
    public string OnTertiary => "#004468";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#003A5A";
    // Error
    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#190B01";
    public string SurfaceVariant => "#3A1F05";
    public string OnSurface => "#FFE0C8";
    public string OnSurfaceVariant => "#CFA27E";
    public string SurfaceDim => "#190B01";
    public string SurfaceBright => "#432507";
    public string SurfaceTint => "#FFAF7E";
    // Background
    public string Background => "#190B01";
    public string OnBackground => "#FFE0C8";
    // Outline
    public string Outline => "#946D4D";
    public string OutlineVariant => "#614124";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#67513E";
    public string InversePrimary => "#8C4F27";
    // Primary Fixed
    public string PrimaryFixed => "#FFAF7E";
    public string OnPrimaryFixed => "#451C00";
    public string PrimaryFixedDim => "#EFA172";
    public string OnPrimaryFixedVariant => "#6D370F";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE9FD";
    public string OnSecondaryFixed => "#364453";
    public string SecondaryFixedDim => "#CDDBEE";
    public string OnSecondaryFixedVariant => "#536070";
    // Tertiary Fixed
    public string TertiaryFixed => "#6FC0FF";
    public string OnTertiaryFixed => "#002338";
    public string TertiaryFixedDim => "#5FB2F1";
    public string OnTertiaryFixedVariant => "#004367";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
