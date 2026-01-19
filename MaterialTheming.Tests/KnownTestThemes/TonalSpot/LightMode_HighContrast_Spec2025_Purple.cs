namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#2F1946";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#604877";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#292032";
    public string OnSecondary => "#E4D5EE";
    public string SecondaryContainer => "#594E62";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3C172C";
    public string OnTertiary => "#FFCCE2";
    public string TertiaryContainer => "#72445B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#27222B";
    public string SurfaceDim => "#E0D7E3";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#2F1946";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#46414A";
    public string OutlineVariant => "#56505A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100D11";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#E4C6FE";
    // Primary Fixed
    public string PrimaryFixed => "#604877";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#543C6B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#594E62";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D4256";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#72445B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#64394F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
