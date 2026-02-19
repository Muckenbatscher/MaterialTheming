namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Orange_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDFCE";
    public string OnPrimary => "#4B1F00";
    public string PrimaryContainer => "#EE8A48";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDFCE";
    public string OnSecondary => "#45230B";
    public string SecondaryContainer => "#CE9878";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDEDA";
    public string OnTertiary => "#600004";
    public string TertiaryContainer => "#FF7C70";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#F5827A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#170B05";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDFCE";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFDFCE";
    // Background
    public string Background => "#170B05";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D8B19A";
    public string OutlineVariant => "#C29C86";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#EE8A48";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EE8A48";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#090200";
    // Tertiary Fixed
    public string TertiaryFixed => "#FF7C70";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FF7C70";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1006";
    public string SurfaceContainer => "#27150A";
    public string SurfaceContainerHigh => "#2F1B0E";
    public string SurfaceContainerHighest => "#382011";
}
