namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#1A000F";
    public string PrimaryContainer => "#B07491";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#2E1923";
    public string SecondaryContainer => "#9B7D8A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#1F042E";
    public string TertiaryContainer => "#D1ACE0";
    public string OnTertiaryContainer => "#3C204B";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#361F2A";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#DFC8D0";
    public string SurfaceDim => "#160B10";
    public string SurfaceBright => "#3D2531";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B5A0A8";
    public string OutlineVariant => "#948188";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#43343B";
    public string InversePrimary => "#582842";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#1A000F";
    public string PrimaryFixedDim => "#F1AECE";
    public string OnPrimaryFixedVariant => "#51223C";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#2E1923";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#503844";
    // Tertiary Fixed
    public string TertiaryFixed => "#EEC7FD";
    public string OnTertiaryFixed => "#1F042E";
    public string TertiaryFixedDim => "#DFB9EE";
    public string OnTertiaryFixedVariant => "#472A56";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2F2228";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#361F2A";
}
