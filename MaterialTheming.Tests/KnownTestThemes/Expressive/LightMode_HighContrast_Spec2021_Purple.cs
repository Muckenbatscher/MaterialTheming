namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#00322F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00534E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#442130";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#653D4D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#421E44";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#623B63";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FA";
    public string SurfaceVariant => "#EFDDED";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C1B5BF";
    public string SurfaceBright => "#FFF7FA";
    public string SurfaceTint => "#006A64";
    // Background
    public string Background => "#FFF7FA";
    public string OnBackground => "#201920";
    // Outline
    public string Outline => "#342934";
    public string OutlineVariant => "#524552";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#362E36";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#73D7CE";
    // Primary Fixed
    public string PrimaryFixed => "#00534E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003A36";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#653D4D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4B2737";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#623B63";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4A254B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAEDF7";
    public string SurfaceContainer => "#ECDFE9";
    public string SurfaceContainerHigh => "#DED1DB";
    public string SurfaceContainerHighest => "#CFC3CD";
}
