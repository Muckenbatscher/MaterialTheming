namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Red_Orange : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D2463D"; //Red
    public string SecondSourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FF9F95";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#F9A299";
    public string OnSecondary => "#501A16";
    public string SecondaryContainer => "#A96058";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFA268";
    public string OnTertiary => "#4B2000";
    public string TertiaryContainer => "#E78543";
    public string OnTertiaryContainer => "#210A00";
    // Error
    public string Error => "#FF9F97";
    public string OnError => "#600008";
    public string ErrorContainer => "#CF433F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#1B0907";
    public string SurfaceVariant => "#3F1B17";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6AAA3";
    public string SurfaceDim => "#1B0907";
    public string SurfaceBright => "#47211D";
    public string SurfaceTint => "#FF9F95";
    // Background
    public string Background => "#1B0907";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BD867F";
    public string OutlineVariant => "#9C6862";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#4B322F";
    public string InversePrimary => "#A3231F";
    // Primary Fixed
    public string PrimaryFixed => "#CF443B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#D0443C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#FCA59B";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EC988E";
    public string OnSecondaryFixedVariant => "#44110E";
    // Tertiary Fixed
    public string TertiaryFixed => "#E78543";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D77837";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#240C0A";
    public string SurfaceContainer => "#2D110F";
    public string SurfaceContainerHigh => "#351613";
    public string SurfaceContainerHighest => "#3F1B17";
}
