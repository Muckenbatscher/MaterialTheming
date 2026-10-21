namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D4E6E9";
    public string OnPrimary => "#324245";
    public string PrimaryContainer => "#39494D";
    public string OnPrimaryContainer => "#D2E3E7";
    // Secondary
    public string Secondary => "#DEE3E5";
    public string OnSecondary => "#3A4042";
    public string SecondaryContainer => "#424849";
    public string OnSecondaryContainer => "#DBE1E2";
    // Tertiary
    public string Tertiary => "#9CD9FF";
    public string OnTertiary => "#00394F";
    public string TertiaryContainer => "#7FBEE3";
    public string OnTertiaryContainer => "#002E41";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3C0507";
    public string ErrorContainer => "#77302E";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#16292C";
    public string OnSurface => "#E3E9EA";
    public string OnSurfaceVariant => "#C9CFD0";
    public string SurfaceDim => "#090F10";
    public string SurfaceBright => "#192F33";
    public string SurfaceTint => "#D4E6E9";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A1A7A8";
    public string OutlineVariant => "#818788";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5FAFC";
    public string InverseOnSurface => "#505657";
    public string InversePrimary => "#48585B";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#324245";
    public string PrimaryFixedDim => "#C6D8DB";
    public string OnPrimaryFixedVariant => "#39494D";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE3E5";
    public string OnSecondaryFixed => "#3A4042";
    public string SecondaryFixedDim => "#D0D5D7";
    public string OnSecondaryFixedVariant => "#424849";
    // Tertiary Fixed
    public string TertiaryFixed => "#9CD9FF";
    public string OnTertiaryFixed => "#00394F";
    public string TertiaryFixedDim => "#8DCBF1";
    public string OnTertiaryFixedVariant => "#004C69";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212728";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#16292C";
}
