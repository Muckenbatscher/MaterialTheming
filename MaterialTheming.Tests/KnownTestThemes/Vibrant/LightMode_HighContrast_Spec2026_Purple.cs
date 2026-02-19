namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#31005A";
    public string OnPrimary => "#E6CAFF";
    public string PrimaryContainer => "#7017BC";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#38004F";
    public string OnSecondary => "#F2C5FF";
    public string SecondaryContainer => "#72318F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#470013";
    public string OnTertiary => "#FFC6CB";
    public string TertiaryContainer => "#8F293C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF3FD";
    public string SurfaceVariant => "#F5D1FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E1538";
    public string SurfaceDim => "#F2C5FF";
    public string SurfaceBright => "#FFF3FD";
    public string SurfaceTint => "#31005A";
    // Background
    public string Background => "#FFF3FD";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#50355A";
    public string OutlineVariant => "#60446A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0425";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DBB6FF";
    // Primary Fixed
    public string PrimaryFixed => "#7017BC";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6300AC";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#72318F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#652382";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8F293C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7F1D31";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
