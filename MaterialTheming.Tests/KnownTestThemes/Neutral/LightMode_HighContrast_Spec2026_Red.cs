namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#2E211F";
    public string OnPrimary => "#ECD5D2";
    public string PrimaryContainer => "#5F4E4C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#292222";
    public string OnSecondary => "#E4D7D5";
    public string SecondaryContainer => "#59504F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#371B28";
    public string OnTertiary => "#FBCEDF";
    public string TertiaryContainer => "#6A4957";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#EBE0DF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#282322";
    public string SurfaceDim => "#E3D7D6";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#2E211F";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#484141";
    public string OutlineVariant => "#575150";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FBE3E0";
    // Primary Fixed
    public string PrimaryFixed => "#5F4E4C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#524341";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#59504F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D4544";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6A4957";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#5D3D4B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
