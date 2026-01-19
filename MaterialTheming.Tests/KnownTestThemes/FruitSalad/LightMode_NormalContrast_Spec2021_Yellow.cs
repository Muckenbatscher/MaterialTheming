namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8E4E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDCC1";
    public string OnPrimaryContainer => "#6C3A00";
    // Secondary
    public string Secondary => "#87521C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDCC1";
    public string OnSecondaryContainer => "#6B3B04";
    // Tertiary
    public string Tertiary => "#626117";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E9E78E";
    public string OnTertiaryContainer => "#4A4900";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E4BF";
    public string OnSurface => "#1D1C0E";
    public string OnSurfaceVariant => "#49482D";
    public string SurfaceDim => "#DEDBC4";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#8E4E00";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#1D1C0E";
    // Outline
    public string Outline => "#7A7959";
    public string OutlineVariant => "#CBC8A4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323122";
    public string InverseOnSurface => "#F5F1DA";
    public string InversePrimary => "#FFB779";
    // Primary Fixed
    public string PrimaryFixed => "#FFDCC1";
    public string OnPrimaryFixed => "#2E1500";
    public string PrimaryFixedDim => "#FFB779";
    public string OnPrimaryFixedVariant => "#6C3A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCC1";
    public string OnSecondaryFixed => "#2E1500";
    public string SecondaryFixedDim => "#FFB779";
    public string OnSecondaryFixedVariant => "#6B3B04";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E78E";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CDCA75";
    public string OnTertiaryFixedVariant => "#4A4900";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#F2EFD8";
    public string SurfaceContainerHigh => "#ECE9D2";
    public string SurfaceContainerHighest => "#E6E3CD";
}
