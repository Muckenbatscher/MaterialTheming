namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFAF7E";
    public string OnPrimary => "#552400";
    public string PrimaryContainer => "#A6643A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B9C8DA";
    public string OnSecondary => "#2A3746";
    public string SecondaryContainer => "#687686";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#91CDFF";
    public string OnTertiary => "#003959";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#002F4A";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#190B01";
    public string SurfaceVariant => "#3A1F05";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEB08A";
    public string SurfaceDim => "#190B01";
    public string SurfaceBright => "#432507";
    public string SurfaceTint => "#FFAF7E";
    // Background
    public string Background => "#190B01";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B58B68";
    public string OutlineVariant => "#946D4D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#483423";
    public string InversePrimary => "#80461E";
    // Primary Fixed
    public string PrimaryFixed => "#FFAF7E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EFA172";
    public string OnPrimaryFixedVariant => "#451C00";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE9FD";
    public string OnSecondaryFixed => "#172533";
    public string SecondaryFixedDim => "#CDDBEE";
    public string OnSecondaryFixedVariant => "#364453";
    // Tertiary Fixed
    public string TertiaryFixed => "#6FC0FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#5FB2F1";
    public string OnTertiaryFixedVariant => "#002338";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
