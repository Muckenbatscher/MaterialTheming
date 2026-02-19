namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F6BA96";
    public string OnPrimary => "#5E361C";
    public string PrimaryContainer => "#74482C";
    public string OnPrimaryContainer => "#FFDCCA";
    // Secondary
    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#543A2B";
    public string SecondaryContainer => "#4F3626";
    public string OnSecondaryContainer => "#DDB8A2";
    // Tertiary
    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#6A5D25";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#61551E";
    // Error
    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#130D09";
    public string SurfaceVariant => "#30231C";
    public string OnSurface => "#F8E1D5";
    public string OnSurfaceVariant => "#BBA79C";
    public string SurfaceDim => "#130D09";
    public string SurfaceBright => "#362922";
    public string SurfaceTint => "#F6BA96";
    // Background
    public string Background => "#130D09";
    public string OnBackground => "#F8E1D5";
    // Outline
    public string Outline => "#847268";
    public string OutlineVariant => "#54453C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#5D534E";
    public string InversePrimary => "#825438";
    // Primary Fixed
    public string PrimaryFixed => "#FCBF9B";
    public string OnPrimaryFixed => "#4B270E";
    public string PrimaryFixedDim => "#EDB18F";
    public string OnPrimaryFixedVariant => "#6D4327";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#533A2A";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#725544";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAE8A2";
    public string OnTertiaryFixed => "#4E420C";
    public string TertiaryFixedDim => "#ECDA95";
    public string OnTertiaryFixedVariant => "#6B5F27";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
