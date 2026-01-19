namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D5BEE9";
    public string OnPrimary => "#4A395C";
    public string PrimaryContainer => "#5D4B6F";
    public string OnPrimaryContainer => "#F0DCFF";
    // Secondary
    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#473C50";
    public string SecondaryContainer => "#42374B";
    public string OnSecondaryContainer => "#C9BAD2";
    // Tertiary
    public string Tertiary => "#FFCCE2";
    public string OnTertiary => "#6B3F55";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#61364C";
    // Error
    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#100D11";
    public string SurfaceVariant => "#29242D";
    public string OnSurface => "#ECE2EE";
    public string OnSurfaceVariant => "#B1A8B3";
    public string SurfaceDim => "#100D11";
    public string SurfaceBright => "#2F2A33";
    public string SurfaceTint => "#D5BEE9";
    // Background
    public string Background => "#100D11";
    public string OnBackground => "#ECE2EE";
    // Outline
    public string Outline => "#7A737D";
    public string OutlineVariant => "#4C464F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#585459";
    public string InversePrimary => "#6A577D";
    // Primary Fixed
    public string PrimaryFixed => "#E4CBF7";
    public string OnPrimaryFixed => "#402F51";
    public string PrimaryFixedDim => "#D5BEE9";
    public string OnPrimaryFixedVariant => "#5D4B6F";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#463B4F";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#63576C";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BBD7";
    public string OnTertiaryFixed => "#4B2338";
    public string TertiaryFixedDim => "#E8AEC9";
    public string OnTertiaryFixedVariant => "#6C3F56";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
