namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFA268";
    public string OnPrimary => "#4B2000";
    public string PrimaryContainer => "#DA7A39";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E5AD8B";
    public string OnSecondary => "#46230B";
    public string SecondaryContainer => "#9A6B4D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#F7A673";
    public string OnTertiary => "#4B2000";
    public string TertiaryContainer => "#CC8152";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BB5840";
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
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#DA7A39";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CA6E2E";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#090200";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#4B270F";
    // Tertiary Fixed
    public string TertiaryFixed => "#CC8152";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#BD7547";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1006";
    public string SurfaceContainer => "#27150A";
    public string SurfaceContainerHigh => "#2F1B0E";
    public string SurfaceContainerHighest => "#382011";
}
