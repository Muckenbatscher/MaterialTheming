namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#692F00";
    public string OnPrimary => "#FFC9AA";
    public string PrimaryContainer => "#BB5800";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#623400";
    public string OnSecondary => "#FFCA9E";
    public string SecondaryContainer => "#AF6100";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#523C00";
    public string OnTertiary => "#FFCD61";
    public string TertiaryContainer => "#956E00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF4EF";
    public string SurfaceVariant => "#FFD5B4";
    public string OnSurface => "#331900";
    public string OnSurfaceVariant => "#5C3611";
    public string SurfaceDim => "#FFCA9F";
    public string SurfaceBright => "#FFF4EF";
    public string SurfaceTint => "#692F00";
    // Background
    public string Background => "#FFF4EF";
    public string OnBackground => "#331900";
    // Outline
    public string Outline => "#7D522B";
    public string OutlineVariant => "#9C6D43";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#F3B989";
    public string InversePrimary => "#FF7B00";
    // Primary Fixed
    public string PrimaryFixed => "#BB5800";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A84F00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#AF6100";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#9D5600";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#956E00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#866200";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
