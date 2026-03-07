namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Red_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D2463D"; //Red
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#510003";
    public string OnPrimary => "#FFCFC9";
    public string PrimaryContainer => "#9E201D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#45120F";
    public string OnSecondary => "#FFCFC9";
    public string SecondaryContainer => "#803F38";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#500204";
    public string OnTertiary => "#FFCFC9";
    public string TertiaryContainer => "#91322B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500010";
    public string OnError => "#FFCECF";
    public string ErrorContainer => "#9F1C32";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3D1916";
    public string SurfaceDim => "#FFCFC9";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#510003";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#623732";
    public string OutlineVariant => "#744641";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#220504";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB1A8";
    // Primary Fixed
    public string PrimaryFixed => "#9E201D";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8D1213";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#803F38";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#72342E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#91322B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#812621";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#FFDAD6";
}
