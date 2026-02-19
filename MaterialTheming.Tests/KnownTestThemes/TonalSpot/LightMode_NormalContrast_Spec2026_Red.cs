namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#8C4E47";
    public string OnPrimary => "#FFF7F6";
    public string PrimaryContainer => "#FDACA3";
    public string OnPrimaryContainer => "#622C27";
    // Secondary
    public string Secondary => "#785753";
    public string OnSecondary => "#FFF7F6";
    public string SecondaryContainer => "#FFDAD6";
    public string OnSecondaryContainer => "#694A46";
    // Tertiary
    public string Tertiary => "#7B5828";
    public string OnTertiary => "#FFF7F3";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#654415";
    // Error
    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F6DDDA";
    public string OnSurface => "#3E2F2D";
    public string OnSurfaceVariant => "#6D5B59";
    public string SurfaceDim => "#EDD5D2";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#8C4E47";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#3E2F2D";
    // Outline
    public string Outline => "#8A7674";
    public string OutlineVariant => "#C3ADAA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130C0C";
    public string InverseOnSurface => "#A79A98";
    public string InversePrimary => "#FDACA3";
    // Primary Fixed
    public string PrimaryFixed => "#FDACA3";
    public string OnPrimaryFixed => "#481814";
    public string PrimaryFixedDim => "#ED9F96";
    public string OnPrimaryFixedVariant => "#6D352F";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#553835";
    public string SecondaryFixedDim => "#F6CAC5";
    public string OnSecondaryFixedVariant => "#745450";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFCF93";
    public string OnTertiaryFixed => "#4F3203";
    public string TertiaryFixedDim => "#F0C187";
    public string OnTertiaryFixedVariant => "#6F4E1E";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
