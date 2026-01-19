namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D5BEE9";
    public string OnPrimary => "#402F51";
    public string PrimaryContainer => "#816D93";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#3C3245";
    public string SecondaryContainer => "#7C7086";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFCCE2";
    public string OnTertiary => "#60354B";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#562C42";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#100D11";
    public string SurfaceVariant => "#29242D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BFB6C1";
    public string SurfaceDim => "#100D11";
    public string SurfaceBright => "#2F2A33";
    public string SurfaceTint => "#D5BEE9";
    // Background
    public string Background => "#100D11";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#99919C";
    public string OutlineVariant => "#7A737D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#3A373C";
    public string InversePrimary => "#604D72";
    // Primary Fixed
    public string PrimaryFixed => "#E4CBF7";
    public string OnPrimaryFixed => "#19092A";
    public string PrimaryFixedDim => "#D5BEE9";
    public string OnPrimaryFixedVariant => "#402F51";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#251C2E";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#463B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BBD7";
    public string OnTertiaryFixed => "#0D0006";
    public string TertiaryFixedDim => "#E8AEC9";
    public string OnTertiaryFixedVariant => "#4B2338";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
