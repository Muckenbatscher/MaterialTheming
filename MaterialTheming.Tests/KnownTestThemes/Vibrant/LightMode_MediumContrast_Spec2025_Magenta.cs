namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#7D0056";
    public string OnPrimary => "#FFC3DF";
    public string PrimaryContainer => "#C93A92";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#6D1A68";
    public string OnSecondary => "#FFC1F1";
    public string SecondaryContainer => "#AC53A2";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1D349A";
    public string OnTertiary => "#CBD1FF";
    public string TertiaryContainer => "#586CD3";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF3F8";
    public string SurfaceVariant => "#FFCEF3";
    public string OnSurface => "#331330";
    public string OnSurfaceVariant => "#573351";
    public string SurfaceDim => "#FFC2F1";
    public string SurfaceBright => "#FFF3F8";
    public string SurfaceTint => "#7D0056";
    // Background
    public string Background => "#FFF3F8";
    public string OnBackground => "#331330";
    // Outline
    public string Outline => "#764F6F";
    public string OutlineVariant => "#946A8B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F031D";
    public string InverseOnSurface => "#E7B6DB";
    public string InversePrimary => "#FC65BD";
    // Primary Fixed
    public string PrimaryFixed => "#C93A92";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#B92C85";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#AC53A2";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#9E4695";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#586CD3";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4B60C5";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
