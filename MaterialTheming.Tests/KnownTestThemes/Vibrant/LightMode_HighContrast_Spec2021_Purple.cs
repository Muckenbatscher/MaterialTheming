namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#430077";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6B00BA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3A2440";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#59415F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#441E41";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#653A5F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BFB5C3";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#8900EA";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#302937";
    public string OutlineVariant => "#4E4654";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#6B00BA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4C0086";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#59415F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#412A47";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#653A5F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4C2448";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8EDFC";
    public string SurfaceContainer => "#EADFED";
    public string SurfaceContainerHigh => "#DBD1DF";
    public string SurfaceContainerHighest => "#CDC3D1";
}
