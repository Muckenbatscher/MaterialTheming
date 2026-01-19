namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#3FD4EA";
    public string OnPrimaryContainer => "#000E10";
    // Secondary
    public string Secondary => "#CEF7FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#9BCBD3";
    public string OnSecondaryContainer => "#000E10";
    // Tertiary
    public string Tertiary => "#FFECE2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFB177";
    public string OnTertiaryContainer => "#170700";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3C494B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#4B5152";
    public string SurfaceTint => "#45D8EE";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DDE4E5";
    // Outline
    public string Outline => "#E5F2F5";
    public string OutlineVariant => "#B7C5C8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DDE4E5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#45D8EE";
    public string OnPrimaryFixedVariant => "#001417";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#9FCED7";
    public string OnSecondaryFixedVariant => "#001417";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC4";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFB781";
    public string OnTertiaryFixedVariant => "#200C00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A2122";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#414849";
}
