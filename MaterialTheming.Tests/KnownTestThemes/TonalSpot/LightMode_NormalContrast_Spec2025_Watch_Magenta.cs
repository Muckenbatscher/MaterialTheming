namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFBCDB";
    public string OnPrimary => "#51223C";
    public string PrimaryContainer => "#693651";
    public string OnPrimaryContainer => "#FFD5E7";
    // Secondary
    public string Secondary => "#FDD9E8";
    public string OnSecondary => "#503844";
    public string SecondaryContainer => "#58404B";
    public string OnSecondaryContainer => "#FAD7E5";
    // Tertiary
    public string Tertiary => "#EEC7FD";
    public string OnTertiary => "#472A56";
    public string TertiaryContainer => "#D1ACE0";
    public string OnTertiaryContainer => "#3C204B";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#361F2A";
    public string OnSurface => "#F9E2EA";
    public string OnSurfaceVariant => "#DFC8D0";
    public string SurfaceDim => "#160B10";
    public string SurfaceBright => "#3D2531";
    public string SurfaceTint => "#FFBCDB";
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
    public string InverseOnSurface => "#615157";
    public string InversePrimary => "#794460";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#51223C";
    public string PrimaryFixedDim => "#F1AECE";
    public string OnPrimaryFixedVariant => "#693651";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#503844";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#58404B";
    // Tertiary Fixed
    public string TertiaryFixed => "#EEC7FD";
    public string OnTertiaryFixed => "#472A56";
    public string TertiaryFixedDim => "#DFB9EE";
    public string OnTertiaryFixedVariant => "#593B67";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2F2228";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#361F2A";
}
