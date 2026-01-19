namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#626117";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9E78E";
    public string OnPrimaryContainer => "#4A4900";
    // Secondary
    public string Secondary => "#616042";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E7E4BF";
    public string OnSecondaryContainer => "#49482D";
    // Tertiary
    public string Tertiary => "#3E6656";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C0ECD7";
    public string OnTertiaryContainer => "#264E3F";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FDF9EC";
    public string SurfaceVariant => "#E6E3D1";
    public string OnSurface => "#1C1C14";
    public string OnSurfaceVariant => "#48473A";
    public string SurfaceDim => "#DDDACD";
    public string SurfaceBright => "#FDF9EC";
    public string SurfaceTint => "#626117";
    // Background
    public string Background => "#FDF9EC";
    public string OnBackground => "#1C1C14";
    // Outline
    public string Outline => "#797869";
    public string OutlineVariant => "#CAC7B6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#313128";
    public string InverseOnSurface => "#F4F1E3";
    public string InversePrimary => "#CDCA75";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CDCA75";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#1D1D06";
    public string SecondaryFixedDim => "#CBC8A4";
    public string OnSecondaryFixedVariant => "#49482D";
    // Tertiary Fixed
    public string TertiaryFixed => "#C0ECD7";
    public string OnTertiaryFixed => "#002116";
    public string TertiaryFixedDim => "#A4D0BC";
    public string OnTertiaryFixedVariant => "#264E3F";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E6";
    public string SurfaceContainer => "#F2EEE0";
    public string SurfaceContainerHigh => "#ECE8DB";
    public string SurfaceContainerHighest => "#E6E2D5";
}
