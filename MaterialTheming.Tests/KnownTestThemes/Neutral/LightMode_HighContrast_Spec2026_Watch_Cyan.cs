namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2026_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#98A9AC";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A1A7A8";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#7FBEE3";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#EA8C86";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#16292C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FEFFFF";
    public string SurfaceDim => "#090F10";
    public string SurfaceBright => "#192F33";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C9CFD0";
    public string OutlineVariant => "#A1A7A8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5FAFC";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C6D8DB";
    public string OnPrimaryFixedVariant => "#122225";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE3E5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D0D5D7";
    public string OnSecondaryFixedVariant => "#1A2022";
    // Tertiary Fixed
    public string TertiaryFixed => "#9CD9FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8DCBF1";
    public string OnTertiaryFixedVariant => "#000F18";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212728";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#16292C";
}
