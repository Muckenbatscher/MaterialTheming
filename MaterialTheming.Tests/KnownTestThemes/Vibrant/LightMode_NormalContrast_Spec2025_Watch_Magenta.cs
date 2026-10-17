namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFBCDB";
    public string OnPrimary => "#560B3B";
    public string PrimaryContainer => "#772957";
    public string OnPrimaryContainer => "#FFD5E7";
    // Secondary
    public string Secondary => "#F1C1FE";
    public string OnSecondary => "#492557";
    public string SecondaryContainer => "#5D386B";
    public string OnSecondaryContainer => "#F8D5FF";
    // Tertiary
    public string Tertiary => "#D1C8FF";
    public string OnTertiary => "#220F68";
    public string TertiaryContainer => "#A295EF";
    public string OnTertiaryContainer => "#130050";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#341D3C";
    public string OnSurface => "#FADFFE";
    public string OnSurfaceVariant => "#E0C6E4";
    public string SurfaceDim => "#17081D";
    public string SurfaceBright => "#3B2244";
    public string SurfaceTint => "#FFBCDB";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B69EBA";
    public string OutlineVariant => "#957E9A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#624E67";
    public string InversePrimary => "#893866";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#560B3B";
    public string PrimaryFixedDim => "#FD99CD";
    public string OnPrimaryFixedVariant => "#772957";
    // Secondary Fixed
    public string SecondaryFixed => "#F1C1FE";
    public string OnSecondaryFixed => "#492557";
    public string SecondaryFixedDim => "#E2B4EF";
    public string OnSecondaryFixedVariant => "#5D386B";
    // Tertiary Fixed
    public string TertiaryFixed => "#D1C8FF";
    public string OnTertiaryFixed => "#220F68";
    public string TertiaryFixedDim => "#B0A2FD";
    public string OnTertiaryFixedVariant => "#423487";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#301F36";
    public string SurfaceContainer => "#3C2A41";
    public string SurfaceContainerHigh => "#47354D";
    public string SurfaceContainerHighest => "#341D3C";
}
