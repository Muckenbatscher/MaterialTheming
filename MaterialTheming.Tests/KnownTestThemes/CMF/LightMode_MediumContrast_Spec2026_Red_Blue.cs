namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Red_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D2463D"; //Red
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#880D0F";
    public string OnPrimary => "#FFCEC9";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#6D302A";
    public string OnSecondary => "#FFCEC9";
    public string SecondaryContainer => "#A96058";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004380";
    public string OnTertiary => "#C6DBFF";
    public string TertiaryContainer => "#185FAA";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#880C14";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#CF433F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#3D1916";
    public string OnSurfaceVariant => "#623732";
    public string SurfaceDim => "#FFCFC9";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#880D0F";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#3D1916";
    // Outline
    public string Outline => "#82534D";
    public string OutlineVariant => "#A26D67";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#220504";
    public string InverseOnSurface => "#E1BCB8";
    public string InversePrimary => "#FF6F63";
    // Primary Fixed
    public string PrimaryFixed => "#CF443B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#BD3730";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#A96058";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#9B544D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#2B6CB7";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#185FAA";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#FFDAD6";
}
