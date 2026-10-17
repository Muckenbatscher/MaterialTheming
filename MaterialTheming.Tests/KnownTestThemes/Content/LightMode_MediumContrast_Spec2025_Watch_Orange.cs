namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C96D2D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#140500";
    public string SecondaryContainer => "#AD7A5C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#0E0700";
    public string TertiaryContainer => "#E3AA2E";
    public string OnTertiaryContainer => "#362500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CF674E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#372012";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#EEC6AF";
    public string SurfaceDim => "#1C0901";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C39E89";
    public string OutlineVariant => "#A17E6B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#4C3222";
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FE9753";
    public string OnPrimaryFixedVariant => "#411A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FDC2A0";
    public string OnSecondaryFixed => "#140500";
    public string SecondaryFixedDim => "#EEB593";
    public string OnSecondaryFixedVariant => "#4D2911";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC655";
    public string OnTertiaryFixed => "#0E0700";
    public string TertiaryFixedDim => "#F3B73C";
    public string OnTertiaryFixedVariant => "#442F00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#372012";
    public string SurfaceContainer => "#432B1B";
    public string SurfaceContainerHigh => "#503525";
    public string SurfaceContainerHighest => "#372012";
}
