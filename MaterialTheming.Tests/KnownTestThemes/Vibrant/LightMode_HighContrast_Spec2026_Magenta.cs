namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#43002D";
    public string OnPrimary => "#FFC4DF";
    public string PrimaryContainer => "#97036A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3F003D";
    public string OnSecondary => "#FFC2F1";
    public string SecondaryContainer => "#802C79";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#001463";
    public string OnTertiary => "#CCD2FF";
    public string TertiaryContainer => "#3045AA";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF3F8";
    public string SurfaceVariant => "#FFCEF3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#331330";
    public string SurfaceDim => "#FFC2F1";
    public string SurfaceBright => "#FFF3F8";
    public string SurfaceTint => "#43002D";
    // Background
    public string Background => "#FFF3F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#573351";
    public string OutlineVariant => "#684261";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F031D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFACD5";
    // Primary Fixed
    public string PrimaryFixed => "#97036A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#83005B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#802C79";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#721E6C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3045AA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#22389E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
