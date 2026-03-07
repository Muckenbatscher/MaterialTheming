namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B12E28";
    public string OnPrimary => "#FFF7F6";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#904B44";
    public string OnSecondary => "#FFF7F6";
    public string SecondaryContainer => "#FCA59B";
    public string OnSecondaryContainer => "#602621";
    // Tertiary
    public string Tertiary => "#A23F37";
    public string OnTertiary => "#FFF7F6";
    public string TertiaryContainer => "#BD534A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#B12B3D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FF6472";
    public string OnErrorContainer => "#3E000B";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#4F2723";
    public string OnSurfaceVariant => "#82534D";
    public string SurfaceDim => "#FFCFC9";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#B12E28";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#4F2723";
    // Outline
    public string Outline => "#A26D67";
    public string OutlineVariant => "#DFA39D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#220504";
    public string InverseOnSurface => "#B79591";
    public string InversePrimary => "#FF665A";
    // Primary Fixed
    public string PrimaryFixed => "#CF443B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#BD3730";
    public string OnPrimaryFixedVariant => "#FFFBFF";
    // Secondary Fixed
    public string SecondaryFixed => "#FCA59B";
    public string OnSecondaryFixed => "#44110E";
    public string SecondaryFixedDim => "#EC988E";
    public string OnSecondaryFixedVariant => "#6B2F29";
    // Tertiary Fixed
    public string TertiaryFixed => "#BD534A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#AD473F";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#FFDAD6";
}
