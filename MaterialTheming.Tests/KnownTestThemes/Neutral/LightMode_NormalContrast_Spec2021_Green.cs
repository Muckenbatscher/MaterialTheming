namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#556254";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D9E6D5";
    public string OnPrimaryContainer => "#3E4A3D";
    // Secondary
    public string Secondary => "#596057";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DDE5D9";
    public string OnSecondaryContainer => "#424940";
    // Tertiary
    public string Tertiary => "#516350";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D4E8D1";
    public string OnTertiaryContainer => "#3A4B3A";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E4E2DF";
    public string OnSurface => "#1B1C1A";
    public string OnSurfaceVariant => "#464745";
    public string SurfaceDim => "#DBDAD7";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#556254";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#1B1C1A";
    // Outline
    public string Outline => "#777775";
    public string OutlineVariant => "#C7C6C3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#30312F";
    public string InverseOnSurface => "#F2F0ED";
    public string InversePrimary => "#BDCABA";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#131E14";
    public string PrimaryFixedDim => "#BDCABA";
    public string OnPrimaryFixedVariant => "#3E4A3D";
    // Secondary Fixed
    public string SecondaryFixed => "#DDE5D9";
    public string OnSecondaryFixed => "#171D16";
    public string SecondaryFixedDim => "#C1C9BE";
    public string OnSecondaryFixedVariant => "#424940";
    // Tertiary Fixed
    public string TertiaryFixed => "#D4E8D1";
    public string OnTertiaryFixed => "#0F1F11";
    public string TertiaryFixedDim => "#B8CCB5";
    public string OnTertiaryFixedVariant => "#3A4B3A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#EAE8E5";
    public string SurfaceContainerHighest => "#E4E2DF";
}
