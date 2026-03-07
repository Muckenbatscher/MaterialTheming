namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Orange_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFA268";
    public string OnPrimary => "#4B2000";
    public string PrimaryContainer => "#E78543";
    public string OnPrimaryContainer => "#210A00";
    // Secondary
    public string Secondary => "#E5AD8B";
    public string OnSecondary => "#46230B";
    public string SecondaryContainer => "#996A4D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#C0BE44";
    public string OnTertiary => "#2E2E00";
    public string TertiaryContainer => "#B2B037";
    public string OnTertiaryContainer => "#222200";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#170B05";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D8B19A";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFA268";
    // Background
    public string Background => "#170B05";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B08C77";
    public string OutlineVariant => "#906E5B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#45352B";
    public string InversePrimary => "#8A4000";
    // Primary Fixed
    public string PrimaryFixed => "#E78543";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D77837";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#090200";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#4B270F";
    // Tertiary Fixed
    public string TertiaryFixed => "#B2B037";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A4A22A";
    public string OnTertiaryFixedVariant => "#121100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1006";
    public string SurfaceContainer => "#27150A";
    public string SurfaceContainerHigh => "#2F1B0E";
    public string SurfaceContainerHighest => "#382011";
}
